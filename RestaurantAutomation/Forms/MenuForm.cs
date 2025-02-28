using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;
using System.Windows.Forms;

namespace RestaurantAutomation.UI.Forms
{
    public partial class MenuForm : Form
    {
        private readonly AppDbContext _context;
        public MenuForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            GetAllCategories();

        }

        private void GetAllCategories()
        {
            var data = _context.Categories.ToList();
            if (data != null)
            {
                cmbCategory.DataSource = data;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "ID";
            }

        }

        private byte[]? currentImageData;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var newMenuItem = new MenuItem
                {
                    Name = txtProductName.Text,
                    CategoryID = (Guid)cmbCategory.SelectedValue, // Doğrudan ID kullan
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Description = txtDescription.Text,
                    Image = currentImageData
                };

                context.MenuItems.Add(newMenuItem);
                context.SaveChanges();

                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems();
            }
        }


        private void LoadMenuItems()
        {
            dgwProducts.DataSource = null;
            dgwProducts.DataSource = _context.MenuItems.ToList();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen resmi PictureBox'ta göster
                    pcbImage.Image = new Bitmap(openFileDialog.FileName);

                    // Resmi byte[] dizisine çevirerek kaydet
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pcbImage.Image.Save(ms, pcbImage.Image.RawFormat);
                        currentImageData = ms.ToArray();
                    }
                }
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.Show();
            this.Hide();
        }
    }
}
