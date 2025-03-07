using RestaurantAutomation.Business.Services;
using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.UI.Forms
{
    public partial class TableForm : Form
    {
        private readonly AppDbContext _context;
        private readonly TableRepository _tableRepository;
        private readonly TableService _tableService;

        public TableForm()
        {
            InitializeComponent();

            _context = new AppDbContext();
            _tableRepository = new TableRepository(_context);
            _tableService = new TableService(_tableRepository);

            LoadTables();
        }

        //private void LoadTables()
        //{
        //    flowLayoutPanel1.Controls.Clear();
        //    var tables = _tableService.GetAll();

        //    foreach (var table in tables)
        //    {
        //        Button tableButton = new Button
        //        {
        //            Text = $"Table {table.TableNumber}\n{table.TableCategory}",
        //            Name = $"btn_{table.ID}",
        //            Size = new Size(120, 100),
        //            Tag = table
        //        };

        //        // Set color based on table status
        //        tableButton.BackColor = table.Status == "Empty" ? Color.GreenYellow : Color.Red;

        //        // Add click handler
        //        tableButton.Click += TableButton_Click;

        //        // Add tooltip showing table details
        //        var toolTip = new ToolTip();
        //        toolTip.SetToolTip(tableButton,
        //            $"Table Number: {table.TableNumber}\n" +
        //            $"Status: {table.Status}\n" +
        //            $"Category: {table.TableCategory}");

        //        flowLayoutPanel1.Controls.Add(tableButton);
        //    }
        //}

        private void LoadTables()
        {
            flowLayoutPanel1.Controls.Clear();
            var tables = _tableService.GetAll().OrderBy(t => t.TableNumber); // Masaları sıralı al

            foreach (var table in tables)
            {
                Button tableButton = new Button
                {
                    Text = $"Table {table.TableNumber}\n{table.TableCategory}",
                    Name = $"btn_{table.ID}",
                    Size = new Size(120, 100),
                    Tag = table
                };

                // Set color based on table status
                tableButton.BackColor = table.Status == "Empty" ? Color.GreenYellow : Color.Red;

                // Add single click handler for selection
                tableButton.Click += TableButton_Click;
                // Add double click handler for status change
                tableButton.DoubleClick += TableButton_DoubleClick;

                // Add tooltip showing table details
                var toolTip = new ToolTip();
                toolTip.SetToolTip(tableButton,
                    $"Table Number: {table.TableNumber}\n" +
                    $"Status: {table.Status}\n" +
                    $"Category: {table.TableCategory}");

                flowLayoutPanel1.Controls.Add(tableButton);
            }
        }

        // Single click - Select table
        private void TableButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Table table)
            {
                selectedTable = table;
                // Visual feedback for selection (optional)
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c is Button b)
                    {
                        b.FlatStyle = FlatStyle.Standard;
                    }
                }
                btn.FlatStyle = FlatStyle.Flat;
            }
        }

        // Double click - Change status
        private void TableButton_DoubleClick(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Table table)
            {
                var result = MessageBox.Show(
                    $"Do you want to change status of Table {table.TableNumber}?",
                    "Change Table Status",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Toggle table status
                    table.Status = table.Status == "Empty" ? "Occupied" : "Empty";
                    _tableService.Update(table);

                    // Update button appearance
                    btn.BackColor = table.Status == "Empty" ? Color.GreenYellow : Color.Red;
                }
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Program.MainFormInstance.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _context.Dispose();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni form oluştur
                Form categoryForm = new Form
                {
                    Text = "Select Table Category",
                    Size = new Size(300, 150),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog
                };

                // ComboBox oluştur ve kategorileri ekle
                ComboBox cmbCategory = new ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Location = new Point(50, 20),
                    Width = 200
                };
                cmbCategory.Items.AddRange(new string[] { "Indoor", "Outdoor", "VIP" });
                cmbCategory.SelectedIndex = 0;

                // Onaylama butonu
                Button btnOK = new Button
                {
                    Text = "OK",
                    DialogResult = DialogResult.OK,
                    Location = new Point(100, 60),
                    Width = 80
                };

                // Form'a öğeleri ekle
                categoryForm.Controls.Add(cmbCategory);
                categoryForm.Controls.Add(btnOK);
                categoryForm.AcceptButton = btnOK;

                // Kullanıcı seçim yaptı mı kontrol et
                if (categoryForm.ShowDialog() == DialogResult.OK)
                {
                    string selectedCategory = cmbCategory.SelectedItem.ToString();

                    // Yeni masa numarasını belirle
                    var maxTableNumber = _tableService.GetAll().Any()
                        ? _tableService.GetAll().Max(t => t.TableNumber)
                        : 0;

                    var newTable = new Table
                    {
                        TableNumber = maxTableNumber + 1,
                        Status = "Empty", // Varsayılan boş durum
                        TableCategory = selectedCategory
                    };

                    _tableService.Create(newTable);
                    LoadTables();
                    MessageBox.Show("Table added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            if (selectedTable != null)
            {
                // Toggle table status
                selectedTable.Status = selectedTable.Status == "Empty" ? "Occupied" : "Empty";
                _tableService.Update(selectedTable);

                // Update button appearance
                LoadTables();
            }

        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            try
            {

                if (selectedTable != null)
                {
                    var result = MessageBox.Show(
                        $"Are you sure you want to delete Table {selectedTable.TableNumber}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _tableService.Delete(selectedTable.ID);
                        LoadTables();
                        MessageBox.Show("Table deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No tables to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add this field at class level
        private Table? selectedTable;

        private void btnJumptoOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTable != null)
                {
                    // Create new instance of OrderForm with the selected table
                    OrderForm orderForm = new OrderForm(selectedTable);
                    // Hide current form
                    this.Hide();
                    // Show OrderForm
                    orderForm.ShowDialog();
                    // When OrderForm closes, show this form again
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Please select a table first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening order form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


//namespace RestaurantAutomation.UI.Forms
//{
//    public partial class TableForm : Form
//    {
//        public TableForm()
//        {
//            InitializeComponent();

//            for (int i = 0; i < 19; i++)
//            {
//                Button b = new Button();
//                b.Text = "Table " + i;
//                b.Name = "btn_" + i;
//                b.Size = new Size(100, 100);

//                if (i % 2 == 0)
//                {
//                    b.BackColor = Color.GreenYellow;
//                }
//                else
//                {
//                    b.BackColor = Color.Red;
//                }
//                flowLayoutPanel1.Controls.Add(b);
//            }
//        }

//        private void btnMainMenu_Click(object sender, EventArgs e)
//        {
//            Program.MainFormInstance.Show();
//            this.Hide();
//        }
//    }
//}
