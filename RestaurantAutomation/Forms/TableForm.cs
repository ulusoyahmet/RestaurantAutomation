using System.Windows.Markup;
using Guna.UI2.WinForms;
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
        //    var tables = _tableService.GetAll().OrderBy(t => t.TableNumber); // Masaları sıralı al

        //    foreach (var table in tables)
        //    {
        //        Guna2Button tableButton = new Guna2Button
        //        {
        //            Text = $"Table {table.TableNumber}\n{table.TableCategory}",
        //            Name = $"btn_{table.ID}",
        //            Size = new Size(120, 100),
        //            Tag = table
        //        };

        //        // Set color based on table status
        //        tableButton.BackColor = table.Status == "Empty" ? Color.GreenYellow : Color.Red;

        //        // Add single click handler for selection
        //        tableButton.Click += TableButton_Click;
        //        // Add double click handler for status change
        //        tableButton.DoubleClick += TableButton_DoubleClick;

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
                Guna2Button tableButton = new Guna2Button
                {
                    Text = $"Table {table.TableNumber}\n{table.TableCategory}",
                    Name = $"btn_{table.ID}",
                    Size = new Size(120, 120),
                    Tag = table,
                    // Center text horizontally
                    TextAlign = HorizontalAlignment.Center,
                    // Set image properties
                    ImageSize = new Size(60, 60),
                    // set image to center of button
                    ImageAlign = HorizontalAlignment.Center,
                    // Position text and image with proper vertical spacing
                    ImageOffset = new Point(12, -25), // Move image up from center
                    TextOffset = new Point(-15, 25), // Move text down from center
                    BorderThickness = 1,
                    BorderColor = Color.Transparent,
                    BorderRadius = 10,
                    FillColor = Color.Black,
                    ForeColor = Color.White // Ensure text is visible on black background
                };


                //Guna2Button tableButton = new Guna2Button
                //{
                //    Text = $"Table {table.TableNumber}\n{table.TableCategory}",
                //    Name = $"btn_{table.ID}",
                //    Size = new Size(120, 120),
                //    Tag = table,
                //    // Center text and image horizontally
                //    TextAlign = HorizontalAlignment.Center,
                //    ImageAlign = HorizontalAlignment.Center,
                //    // Set image size
                //    ImageSize = new Size(60, 60),
                //    // Center text and image vertically
                //    TextOffset = new Point(0, 20), // Adjust this value to position text right under the image
                //    ImageOffset = new Point(0, -20), // Adjust this value to position image above the text
                //    BorderThickness = 1,
                //    BorderColor = Color.Transparent,
                //    BorderRadius = 10,
                //    FillColor = Color.Black
                //};


                // Set background image based on table status
                if (table.Status == "Empty")
                {
                    tableButton.Image = Properties.Resources.empty; // Replace with your empty table image resource
                }
                else
                {
                    tableButton.Image = Properties.Resources.occupied; // Replace with your occupied table image resource
                }

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
        // Single click - Select table
        private void TableButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag is Table table)
            {
                selectedTable = table;
                // Visual feedback for selection
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c is Guna2Button b)
                    {
                        b.BorderThickness = 1;
                        b.BorderColor = Color.Transparent;
                        b.FillColor = Color.White;
                    }
                }
                // Make borders of Guna2Button thicker and darker
                btn.BorderThickness = 3;
                btn.BorderColor = Color.DarkBlue;
                btn.FillColor = Color.LightBlue;
            }
        }

        // Double click - Change status
        private void TableButton_DoubleClick(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag is Table table)
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
                    btn.Image = table.Status == "Empty" ? Properties.Resources.empty : Properties.Resources.occupied;
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
                    Size = new Size(300, 200),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog
                };

                // ComboBox oluştur ve kategorileri ekle
                Guna2ComboBox cmbCategory = new Guna2ComboBox
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Location = new Point(50, 20),
                    Width = 200
                };
                cmbCategory.Items.AddRange(["Indoor", "Outdoor", "Garden"]);
                cmbCategory.SelectedIndex = 0;

                // Onaylama butonu
                Guna2Button btnOK = new Guna2Button
                {
                    Text = "OK",
                    Location = new Point(100, 70),
                    Width = 80,
                    Height = 50
                };

                // OK button click event to set DialogResult and close the form
                btnOK.Click += (s, args) =>
                {
                    categoryForm.DialogResult = DialogResult.OK;
                    categoryForm.Close();
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

