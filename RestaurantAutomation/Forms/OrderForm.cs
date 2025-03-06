//using RestaurantAutomation.Business.Services;
//using RestaurantAutomation.DataAccess.Context;
//using RestaurantAutomation.DataAccess.Repositories;
//using RestaurantAutomation.Entities.Models;
//using System.Data;

//namespace RestaurantAutomation.UI.Forms
//{
//   public partial class OrderForm : Form
//    {
//        private readonly OrderService _orderService;
//        private readonly TableService _tableService;
//        private readonly MenuItemService _menuItemService;
//        private readonly CategoryService _categoryService;
//        private readonly OrderDetailService _orderDetailService;

//        private readonly OrderRepository _orderRepository;
//        private readonly TableRepository _tableRepository;
//        private readonly MenuItemRepository _menuItemRepository;
//        private readonly CategoryRepository _categoryRepository;
//        private readonly OrderDetailRepository _orderDetailRepository;

//        private readonly AppDbContext _context;
//        private readonly AppDbContext _dbContext;

//        private Guid? _currentOrderId = null;
//        private Guid? _currentTableId = null;
//        private DataTable _orderItemsTable;
//        //private Guid _currentOrderId;
//        //private DataTable _orderItemsTable;
//        //private decimal _totalAmount = 0;

//        private readonly Table _currentTable;

//        public OrderForm(Table table)
//        {
//            InitializeComponent();
//            _context = new AppDbContext();
//            _dbContext = new AppDbContext();
//            _orderRepository = new OrderRepository(_context);
//            _tableRepository = new TableRepository(_context);
//            _menuItemRepository = new MenuItemRepository(_context);
//            _categoryRepository = new CategoryRepository(_context);
//            _orderDetailRepository = new OrderDetailRepository(_context, _dbContext);

//            _orderService = new OrderService(_orderRepository);
//            _tableService = new TableService(_tableRepository);
//            _menuItemService = new MenuItemService(_menuItemRepository);
//            _categoryService = new CategoryService(_categoryRepository);
//            _orderDetailService = new OrderDetailService(_orderDetailRepository);

//            _currentTable = table;

//        }

//        private void btnMainMenu_Click(object sender, EventArgs e)
//        {
//            Program.MainFormInstance.Show();
//            this.Hide();
//        }

//        private void OrderForm_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnStarters_Click(object sender, EventArgs e)
//        {
//            ShowCategoryItems("Starters");
//        }

//        private void ShowCategoryItems(string categoryName)
//        {
//            var category = _categoryService.GetAll().FirstOrDefault(c => c.Name == categoryName);
//            if (category == null) return;

//            //Yeni form oluştur:          

//            Form menuItemsForm = new Form()
//            {
//                Text = categoryName,
//                Size = new Size(400, 600),
//                StartPosition = FormStartPosition.CenterScreen,
//                FormBorderStyle = FormBorderStyle.FixedDialog,
//                MaximizeBox = false,
//                MinimizeBox = false
//            };

//            FlowLayoutPanel panel = new FlowLayoutPanel()
//            {
//                Dock = DockStyle.Fill,
//                AutoScroll = true,
//                Padding = new Padding(10)
//            };
//            menuItemsForm.Controls.Add(panel);

//            // Veriyi al ve kategoriye göre filtrele
//            var menuItems = _menuItemService.GetAll().Where(m => m.CategoryID == category.ID);


//            foreach (var item in menuItems)
//            {
//                Button menuItemButton = new Button()
//                {
//                    Text = $"{item.Name}\n{item.Price:C2}",
//                    Tag = item,
//                    Width = 120,
//                    Height = 50
//                };
//                menuItemButton.Click += (sender, e) =>
//                {
//                    AddToOrder((MenuItem)((Button)sender).Tag);
//                    menuItemsForm.Close();
//                };
//                panel.Controls.Add(menuItemButton);
//            }
//            menuItemsForm.Show();

//        }

//        private void AddToOrder(MenuItem tag)
//        {
//            int quantity = 1;
//            decimal totalPrice = tag.Price * quantity;

//            DataGridViewRow row = new DataGridViewRow();
//            row.Cells.Add(new DataGridViewButtonCell() { Value = "Sil" });
//            row.Cells.Add(new DataGridViewTextBoxCell() { Value = tag.Name });
//            row.Cells.Add(new DataGridViewTextBoxCell() { Value = quantity });
//            row.Cells.Add(new DataGridViewTextBoxCell() { Value = tag.Price });
//            row.Cells.Add(new DataGridViewTextBoxCell() { Value = totalPrice });

//            dataGridView1.Rows.Add(row);
//        }

//        private void btnMainCourses_Click(object sender, EventArgs e)
//        {
//            ShowCategoryItems("MainCourses");
//        }

//        private void btnDesserts_Click(object sender, EventArgs e)
//        {
//            ShowCategoryItems("Desserts");
//        }

//        private void btnBeverages_Click(object sender, EventArgs e)
//        {
//            ShowCategoryItems("Beverages");
//        }
//    }
//}
//*/
using RestaurantAutomation.Business.Services;
using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
        private Guid? _currentTableId = null;
        private DataTable _orderItemsTable;

        public OrderForm(Table table)
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

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            _orderItemsTable = new DataTable();
            _orderItemsTable.Columns.Add("Id", typeof(Guid));
            _orderItemsTable.Columns.Add("ProductName", typeof(string));
            _orderItemsTable.Columns.Add("Quantity", typeof(int));
            _orderItemsTable.Columns.Add("Price", typeof(decimal));
            _orderItemsTable.Columns.Add("TotalPrice", typeof(decimal));

            // DataGridView kontrolünü oluştur (eğer varsa tasarımda, kod burayı atlayacaktır)
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

            // Sil butonu sütunu ekle
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Sil";
            deleteButtonColumn.Text = "Sil";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Name = "DeleteColumn";
            deleteButtonColumn.Width = 60;

            // Sütun eklenmiş mi kontrol et, eklenmediyse ekle
            if (dataGridView1.Columns["DeleteColumn"] == null)
            {
                dataGridView1.Columns.Add(deleteButtonColumn);
            }

            // Id sütununu gizle
            dataGridView1.Columns["Id"].Visible = false;

            // DataGridView olayları
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Total değerini güncelle
            UpdateTotal();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sil butonu tıklandığında
            if (e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                Guid itemId = (Guid)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                RemoveOrderItem(e.RowIndex, itemId);
            }
        }

        private void RemoveOrderItem(int rowIndex, Guid menuItemId)
        {
            // Eğer aktif sipariş varsa, veritabanından da sil
            if (_currentOrderId.HasValue)
            {
                var orderDetails = _orderDetailService.GetAll()
                    .Where(od => od.OrderID == _currentOrderId.Value && od.MenuItemID == menuItemId)
                    .FirstOrDefault();

                if (orderDetails != null)
                {
                    _orderDetailService.Delete(orderDetails.ID);
                }
            }

            // DataTable'dan satırı kaldır
            _orderItemsTable.Rows.RemoveAt(rowIndex);

            // Toplamı güncelle
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in _orderItemsTable.Rows)
            {
                total += Convert.ToDecimal(row["TotalPrice"]);
            }

            // Total Label'ı güncelle
            lblTotalAmount.Text = total.ToString("C2");
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Masa numaralarını combobox'a yükle
            LoadTableNumbers();
        }

        private void LoadTableNumbers()
        {
            var tables = _tableService.GetAll();
            cmbTableNo.Items.Clear();
            foreach (var table in tables)
            {
                cmbTableNo.Items.Add(table.TableNumber);
            }

            if (cmbTableNo.Items.Count > 0)
            {
                cmbTableNo.SelectedIndex = 0;
            }
        }

        private void cmbTableNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTableNo.SelectedItem != null)
            {
                int tableNumber = Convert.ToInt32(cmbTableNo.SelectedItem);
                var table = _tableService.GetAll().FirstOrDefault(t => t.TableNumber == tableNumber);

                if (table != null)
                {
                    _currentTableId = table.ID;
                    lblOrderStatus.Text = table.Status;

                    // Eğer masa dolu ise, aktif siparişi yükle
                    if (table.Status == "Dolu")
                    {
                        LoadActiveOrder(table.ID);
                    }
                    else
                    {
                        // Yeni sipariş için tabloyu temizle
                        _orderItemsTable.Clear();
                        _currentOrderId = null;
                    }
                }
            }
        }

        private void LoadActiveOrder(Guid tableId)
        {
            var order = _orderService.GetAll().FirstOrDefault(o => o.TableID == tableId && o.Payment == null);

            if (order != null)
            {
                _currentOrderId = order.ID;
                _orderItemsTable.Clear();

                // Sipariş detaylarını yükle
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
            var category = _categoryService.GetAll().FirstOrDefault(c => c.Name == categoryName);
            if (category == null) return;

            // Yeni form oluştur
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

            // Kategorideki menü öğelerini yükle
            var menuItems = _menuItemService.GetAll().Where(m => m.CategoryID == category.ID);

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

        private void AddItemToOrder(MenuItem menuItem)
        {
            // Eğer masa seçilmemişse
            if (!_currentTableId.HasValue)
            {
                MessageBox.Show("Lütfen önce bir masa seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Eğer aynı üründen varsa, miktarını artır
            bool itemExists = false;
            foreach (DataRow row in _orderItemsTable.Rows)
            {
                if ((Guid)row["Id"] == menuItem.ID)
                {
                    int currentQuantity = Convert.ToInt32(row["Quantity"]);
                    row["Quantity"] = currentQuantity + 1;
                    row["TotalPrice"] = menuItem.Price * (currentQuantity + 1);
                    itemExists = true;

                    // Eğer aktif sipariş varsa, sipariş detayını güncelle
                    if (_currentOrderId.HasValue)
                    {
                        UpdateOrderDetail(menuItem.ID, currentQuantity + 1);
                    }

                    break;
                }
            }

            // Eğer ürün daha önce eklenmemişse, yeni satır ekle
            if (!itemExists)
            {
                DataRow newRow = _orderItemsTable.NewRow();
                newRow["Id"] = menuItem.ID;
                newRow["ProductName"] = menuItem.Name;
                newRow["Quantity"] = 1;
                newRow["Price"] = menuItem.Price;
                newRow["TotalPrice"] = menuItem.Price;
                _orderItemsTable.Rows.Add(newRow);

                // Eğer aktif sipariş yoksa, yeni sipariş oluştur
                if (!_currentOrderId.HasValue)
                {
                    CreateNewOrder();
                }

                // Sipariş detayı ekle
                AddOrderDetail(menuItem.ID, 1);
            }

            // Toplam tutarı güncelle
            UpdateTotal();

            // Masa durumunu güncelle
            UpdateTableStatus("Dolu");
        }

        private void CreateNewOrder()
        {
            var order = new Order
            {
                ID = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                TableID = _currentTableId.Value                
            };

            _orderService.Create(order);
            _currentOrderId = order.ID;
        }

        private void AddOrderDetail(Guid menuItemId, int quantity)
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

        private void UpdateOrderDetail(Guid menuItemId, int newQuantity)
        {
            var orderDetail = _orderDetailService.GetAll()
                .FirstOrDefault(od => od.OrderID == _currentOrderId.Value && od.MenuItemID == menuItemId);

            if (orderDetail != null)
            {
                orderDetail.Quantity = newQuantity;
                _orderDetailService.Update(orderDetail);
            }
        }

        private void UpdateTableStatus(string status)
        {
            if (_currentTableId.HasValue)
            {
                var table = _tableService.GetByID(_currentTableId.Value);
                table.Status = status;
                _tableService.Update(table);

                // Status label'ı güncelle
                lblOrderStatus.Text = status;
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if (!_currentOrderId.HasValue || _orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Tamamlanacak sipariş bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ödeme formunu açabilirsiniz burada
            MessageBox.Show("Sipariş tamamlandı. Ödeme ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // PaymentForm açılabilir
            // PaymentForm paymentForm = new PaymentForm(_currentOrderId.Value);
            // paymentForm.ShowDialog();

            // Masa durumunu güncelle
            UpdateTableStatus("Boş");

            // Sipariş listesini temizle
            _orderItemsTable.Clear();
            _currentOrderId = null;

            // Toplamı güncelle
            UpdateTotal();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (!_currentOrderId.HasValue)
            {
                MessageBox.Show("İptal edilecek sipariş bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bu siparişi iptal etmek istediğinizden emin misiniz?", "Sipariş İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Sipariş detaylarını sil
                var orderDetails = _orderDetailService.GetAll().Where(od => od.OrderID == _currentOrderId.Value);
                foreach (var detail in orderDetails)
                {
                    _orderDetailService.Delete(detail.ID);
                }

                // Siparişi sil
                _orderService.Delete(_currentOrderId.Value);

                // Masa durumunu güncelle
                UpdateTableStatus("Boş");

                // Sipariş listesini temizle
                _orderItemsTable.Clear();
                _currentOrderId = null;

                // Toplamı güncelle
                UpdateTotal();

                MessageBox.Show("Sipariş başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (!_currentOrderId.HasValue || _orderItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Ödenecek sipariş bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ödeme formunu açabilirsiniz
            MessageBox.Show("Ödeme ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // PaymentForm açılabilir
            // PaymentForm paymentForm = new PaymentForm(_currentOrderId.Value);
            // paymentForm.ShowDialog();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (!_currentOrderId.HasValue)
            {
                MessageBox.Show("Not eklemek için aktif bir sipariş olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Not ekleme diyaloğu
            string note = "";

            // Basit bir input diyaloğu
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

                // Notu textbox'a ekle
                txtNote.Text = note;

                MessageBox.Show("Not başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            // Sipariş geçmişi formunu açabilirsiniz
            MessageBox.Show("Sipariş geçmişi ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // OrderHistoryForm açılabilir
            // OrderHistoryForm historyForm = new OrderHistoryForm();
            // historyForm.ShowDialog();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Program.MainFormInstance.Show();
            this.Hide();
        }
    }
}
