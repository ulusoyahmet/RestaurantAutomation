using RestaurantAutomation.Business.Services;
using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;
using System.Data;

namespace RestaurantAutomation.UI.Forms
{
    public partial class OrderForm : Form
    {
        private readonly OrderService _orderService;
        private readonly TableService _tableService;
        private readonly MenuItemService _menuItemService;
        private readonly CategoryService _categoryService;
        private readonly OrderDetailService _orderDetailService;

        private readonly OrderRepository _orderRepository;
        private readonly TableRepository _tableRepository;
        private readonly MenuItemRepository _menuItemRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly OrderDetailRepository _orderDetailRepository;

        private readonly AppDbContext _context;
        private readonly AppDbContext _dbContext;

        private Guid? _currentOrderId = null;
        private Table _currentTable = null;
        private DataTable _orderItemsTable;

        public OrderForm(Table selectedTable)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _dbContext = new AppDbContext();
            _orderRepository = new OrderRepository(_context);
            _tableRepository = new TableRepository(_context);
            _menuItemRepository = new MenuItemRepository(_context);
            _categoryRepository = new CategoryRepository(_context);
            _orderDetailRepository = new OrderDetailRepository(_context, _dbContext);

            _orderService = new OrderService(_orderRepository);
            _tableService = new TableService(_tableRepository);
            _menuItemService = new MenuItemService(_menuItemRepository);
            _categoryService = new CategoryService(_categoryRepository);
            _orderDetailService = new OrderDetailService(_orderDetailRepository);

            if (selectedTable == null)
            {
                int tableNumber = Convert.ToInt32(cmbTableNo.SelectedItem);
                var table = _tableService.GetAll().FirstOrDefault(t => t.TableNumber == tableNumber);
            }
            else
            {
                _currentTable = selectedTable; // Seçili masayı ayarla
            }

            InitializeDataGridView();

            if (_currentTable != null)
            {
                cmbTableNo.Text = _currentTable.TableNumber.ToString();
                lblOrderStatus.Text = _currentTable.Status;

                // Eğer masa doluysa, aktif siparişi yükle
                if (_currentTable.Status == "Occupied")
                {
                    LoadActiveOrder(_currentTable.ID);
                }
            }

            if (_currentTable != null)
            {
                cmbTableNo.Text = _currentTable.TableNumber.ToString();
                lblOrderStatus.Text = _currentTable.Status;

                // If table is occupied, load the active order
                if (_currentTable.Status == "Occupied")
                {
                    LoadActiveOrder(_currentTable.ID);
                }
            }
        }

        private void InitializeDataGridView()
        {
            _orderItemsTable = new DataTable();
            _orderItemsTable.Columns.Add("Id", typeof(Guid));
            _orderItemsTable.Columns.Add("ProductName", typeof(string));
            _orderItemsTable.Columns.Add("Quantity", typeof(int));
            _orderItemsTable.Columns.Add("Price", typeof(decimal));
            _orderItemsTable.Columns.Add("TotalPrice", typeof(decimal));

            // If dataGridView1 doesn't exist in the design, create it programmatically
            if (dataGridView1 == null)
            {
                dataGridView1 = new DataGridView();
                dataGridView1.Name = "dataGridView1";
                dataGridView1.Location = new Point(166, 112);
                dataGridView1.Size = new Size(610, 220);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.Controls.Add(dataGridView1);
            }

            dataGridView1.DataSource = _orderItemsTable;

            // Add delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Sil";
            deleteButtonColumn.Text = "Sil";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Name = "DeleteColumn";
            deleteButtonColumn.Width = 100;
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Check if column already exists before adding
            if (dataGridView1.Columns["DeleteColumn"] == null)
            {
                dataGridView1.Columns.Add(deleteButtonColumn);
            }

            // Hide Id column
            dataGridView1.Columns["Id"].Visible = false;

            // Register event handler
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Update total
            UpdateTotal();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle delete button click
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                dataGridView1.Columns["DeleteColumn"] != null &&
                e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index)
            {
                Guid itemId = (Guid)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                RemoveOrderItem(e.RowIndex, itemId);
            }
        }

        private void RemoveOrderItem(int rowIndex, Guid menuItemId)
        {
            try
            {
                // Eğer aktif bir sipariş varsa, veritabanından sil
                if (_currentOrderId.HasValue)
                {
                    var orderDetails = _orderDetailService.GetAll()
                        .FirstOrDefault(od => od.OrderID == _currentOrderId.Value && od.MenuItemID == menuItemId);

                    if (orderDetails != null)
                    {
                        // Bileşik anahtarı kullanarak silme işlemi yap
                        _orderDetailService.DeleteByOrderProductID(orderDetails.OrderID, orderDetails.MenuItemID);
                    }
                }

                // DataTable'dan sil
                _orderItemsTable.Rows.RemoveAt(rowIndex);

                // Toplamı güncelle
                UpdateTotal();

                // Siparişte ürün kalmadıysa, masa durumunu Boş olarak değiştir
                if (_orderItemsTable.Rows.Count == 0)
                {
                    UpdateTableStatus("Empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in _orderItemsTable.Rows)
            {
                total += Convert.ToDecimal(row["TotalPrice"]);
            }

            // Update total label
            lblTotalAmount.Text = total.ToString("C2");
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Load table numbers into combobox
            LoadTableNumbers();
        }

        private void LoadTableNumbers()
        {
            try
            {
                var tables = _tableService.GetAll().OrderBy(t => t.TableNumber);
                cmbTableNo.Items.Clear();
                foreach (var table in tables)
                {
                    cmbTableNo.Items.Add(table.TableNumber);
                }

                if (cmbTableNo.Items.Count > 0)
                {
                    // Only set selected index if the current table isn't already selected
                    if (_currentTable == null)
                    {
                        cmbTableNo.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Masa bilgileri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadActiveOrder(Guid tableId)
        {
            try
            {
                var order = _orderService.GetAll().FirstOrDefault(o => o.TableID == tableId && o.Payment == null);

                if (order != null)
                {
                    _currentOrderId = order.ID;
                    _orderItemsTable.Clear();

                    // Load order details
                    var orderDetails = _orderDetailService.GetAll().Where(od => od.OrderID == order.ID);

                    foreach (var detail in orderDetails)
                    {
                        var menuItem = _menuItemService.GetByID(detail.MenuItemID);
                        if (menuItem != null)
                        {
                            DataRow row = _orderItemsTable.NewRow();
                            row["Id"] = menuItem.ID;
                            row["ProductName"] = menuItem.Name;
                            row["Quantity"] = detail.Quantity;
                            row["Price"] = menuItem.Price;
                            row["TotalPrice"] = menuItem.Price * detail.Quantity;
                            _orderItemsTable.Rows.Add(row);
                        }
                    }

                    UpdateTotal();
                }
                else
                {
                    // No active order for this table
                    _currentOrderId = null;
                    _orderItemsTable.Clear();
                    UpdateTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş bilgisi alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStarters_Click(object sender, EventArgs e)
        {
            OpenMenuItemsForm("Starters");
        }

        private void btnMainCourses_Click(object sender, EventArgs e)
        {
            OpenMenuItemsForm("Main Courses");
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            OpenMenuItemsForm("Desserts");
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            OpenMenuItemsForm("Beverages");
        }

        private void OpenMenuItemsForm(string categoryName)
        {
            try
            {
                var category = _categoryService.GetAll().FirstOrDefault(c => c.Name == categoryName);
                if (category == null)
                {
                    MessageBox.Show($"{categoryName} kategorisi bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new form
                Form menuItemsForm = new Form
                {
                    Text = categoryName,
                    Width = 500,
                    Height = 400,
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                FlowLayoutPanel panel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    Padding = new Padding(10)
                };

                menuItemsForm.Controls.Add(panel);

                // Load menu items for the category
                var menuItems = _menuItemService.GetAll().Where(m => m.CategoryID == category.ID);

                if (!menuItems.Any())
                {
                    MessageBox.Show($"{categoryName} kategorisinde ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (MenuItem item in menuItems)
                {
                    Button itemButton = new Button
                    {
                        Text = $"{item.Name}\n{item.Price:C2}",
                        Width = 120,
                        Height = 80,
                        Tag = item,
                        Margin = new Padding(5)
                    };

                    itemButton.Click += (sender, e) =>
                    {
                        AddItemToOrder(item);
                        menuItemsForm.Close();
                    };

                    panel.Controls.Add(itemButton);
                }

                menuItemsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Menü öğeleri yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddItemToOrder(MenuItem menuItem)
        {
            try
            {
                // Check if table is selected
                if (_currentTable == null)
                {
                    MessageBox.Show("Lütfen önce bir masa seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if item already exists in order
                bool itemExists = false;
                foreach (DataRow row in _orderItemsTable.Rows)
                {
                    if ((Guid)row["Id"] == menuItem.ID)
                    {
                        int currentQuantity = Convert.ToInt32(row["Quantity"]);
                        row["Quantity"] = currentQuantity + 1;
                        row["TotalPrice"] = menuItem.Price * (currentQuantity + 1);
                        itemExists = true;

                        // If there's an active order, update order detail
                        if (_currentOrderId.HasValue)
                        {
                            UpdateOrderDetail(menuItem.ID, currentQuantity + 1);
                        }

                        break;
                    }
                }

                // If item does not exist, add new row
                if (!itemExists)
                {
                    DataRow newRow = _orderItemsTable.NewRow();
                    newRow["Id"] = menuItem.ID;
                    newRow["ProductName"] = menuItem.Name;
                    newRow["Quantity"] = 1;
                    newRow["Price"] = menuItem.Price;
                    newRow["TotalPrice"] = menuItem.Price;
                    _orderItemsTable.Rows.Add(newRow);

                    // If no active order, create new one
                    if (!_currentOrderId.HasValue)
                    {
                        CreateNewOrder();
                    }

                    // Add order detail
                    AddOrderDetail(menuItem.ID, 1);
                }

                // Update total amount
                UpdateTotal();

                // Update table status
                UpdateTableStatus("Occupied");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ürün eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewOrder()
        {
            try
            {
                if (_currentTable == null)
                {
                    MessageBox.Show("Sipariş oluşturmak için bir masa seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var order = new Order
                {
                    ID = Guid.NewGuid(),
                    OrderDate = DateTime.Now,
                    TableID = _currentTable.ID
                };

                _orderService.Create(order);
                _currentOrderId = order.ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş oluşturulurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddOrderDetail(Guid menuItemId, int quantity)
        {
            try
            {
                var orderDetail = new OrderDetail
                {
                    ID = Guid.NewGuid(),
                    OrderID = _currentOrderId.Value,
                    MenuItemID = menuItemId,
                    Quantity = quantity
                };

                _orderDetailService.Create(orderDetail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş detayı eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateOrderDetail(Guid menuItemId, int newQuantity)
        {
            try
            {
                var orderDetail = _orderDetailService.GetAll()
                    .FirstOrDefault(od => od.OrderID == _currentOrderId.Value && od.MenuItemID == menuItemId);

                if (orderDetail != null)
                {
                    orderDetail.Quantity = newQuantity;
                    _orderDetailService.Update(orderDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş detayı güncellenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTableStatus(string status)
        {
            try
            {
                if (_currentTable != null)
                {
                    var table = _tableService.GetByID(_currentTable.ID);
                    table.Status = status;
                    _tableService.Update(table);

                    // Update status label
                    lblOrderStatus.Text = status;

                    // Also update the current table object's status
                    _currentTable.Status = status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Masa durumu güncellenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if (!_currentOrderId.HasValue || _orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Tamamlanacak sipariş bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // You can open payment form here
                MessageBox.Show("Sipariş tamamlandı. Ödeme ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // PaymentForm paymentForm = new PaymentForm(_currentOrderId.Value);
                // paymentForm.ShowDialog();

                // Update table status
                UpdateTableStatus("Empty");

                // Clear order list
                _orderItemsTable.Clear();
                _currentOrderId = null;

                // Update total
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş tamamlanırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            //if (!_currentOrderId.HasValue)
            //{
            //    MessageBox.Show("İptal edilecek sipariş bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            DialogResult result = MessageBox.Show("Bu siparişi iptal etmek istediğinizden emin misiniz?", "Sipariş İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete order details
                    //var orderDetails = _orderDetailService.GetAll().Where(od => od.OrderID == _currentOrderId.Value);
                    //foreach (var detail in orderDetails)
                    //{
                    //    var product = _menuItemService.GetByID(detail.MenuItemID);
                    //    _orderDetailService.DeleteByOrderProductID(detail.ID, product.ID);
                    //}

                    // Delete order
                    //_orderService.Delete(_currentOrderId.Value);

                    // Update table status
                    UpdateTableStatus("Empty");

                    dataGridView1.Rows.Clear();

                    // Clear order list
                    _orderItemsTable.Clear();
                    _currentOrderId = null;

                    // Update total
                    UpdateTotal();

                    MessageBox.Show("Sipariş başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sipariş iptal edilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (!_currentOrderId.HasValue || _orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Ödenecek sipariş bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // You can open payment form here
                MessageBox.Show("Ödeme ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // PaymentForm paymentForm = new PaymentForm(_currentOrderId.Value);
                // paymentForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödeme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (!_currentOrderId.HasValue)
            {
                MessageBox.Show("Not eklemek için aktif bir sipariş olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Note adding dialog
                string note = "";

                // Simple input dialog
                Form noteForm = new Form
                {
                    Width = 400,
                    Height = 200,
                    Text = "Sipariş Notu Ekle",
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                TextBox txtNote = new TextBox
                {
                    Multiline = true,
                    Width = 350,
                    Height = 100,
                    Location = new Point(20, 20)
                };

                Button btnSave = new Button
                {
                    Text = "Kaydet",
                    Location = new Point(150, 130),
                    DialogResult = DialogResult.OK
                };

                noteForm.Controls.Add(txtNote);
                noteForm.Controls.Add(btnSave);
                noteForm.AcceptButton = btnSave;

                if (noteForm.ShowDialog() == DialogResult.OK)
                {
                    note = txtNote.Text;
                    richTextBox1.Text = note;

                    Order currentOrder = _orderRepository.GetByID(Guid.Parse(_currentOrderId.ToString()));
                    currentOrder.Note = note;
                    _orderRepository.Update(currentOrder);
                    MessageBox.Show("Not başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblOrderNotes.Text = "Note: " + note;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Not eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            try
            {
                // You can open order history form here
                MessageBox.Show("Sipariş geçmişi ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // OrderHistoryForm historyForm = new OrderHistoryForm();
                // historyForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş geçmişi açılırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            // Go back to main menu
            if (Program.MainFormInstance != null)
            {
                Program.MainFormInstance.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Dispose database contexts to prevent memory leaks
            _context?.Dispose();
            _dbContext?.Dispose();
        }

        private void cmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTableNo.SelectedItem != null)
            {
                try
                {
                    int tableNumber = Convert.ToInt32(cmbTableNo.SelectedItem);
                    var table = _tableService.GetAll().FirstOrDefault(t => t.TableNumber == tableNumber);

                    if (table != null)
                    {
                        _currentTable = table;
                        lblOrderStatus.Text = table.Status;

                        // If table is occupied, load active order
                        if (table.Status == "Occupied")
                        {
                            LoadActiveOrder(table.ID);
                        }
                        else
                        {
                            // Clear table for new order
                            _orderItemsTable.Clear();
                            _currentOrderId = null;
                            UpdateTotal();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Masa bilgisi alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}