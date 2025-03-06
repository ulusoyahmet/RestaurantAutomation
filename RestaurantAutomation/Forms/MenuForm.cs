using RestaurantAutomation.Business.Services;
using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;
using System.Windows.Forms;

namespace RestaurantAutomation.UI.Forms
{
    public partial class MenuForm : Form
    {
        private readonly AppDbContext _context;
        private readonly MenuItemService _menuItemService;
        private readonly MenuItemRepository menuItemRepository;

        public MenuForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            menuItemRepository = new MenuItemRepository(_context);
            _menuItemService = new MenuItemService(menuItemRepository);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            GetAllProducts(null);
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

            try
            {
                // if the selectedMenuItem is null, it means that the user is trying to add a new product
                if (selectedMenuItem == null)
                {
                    var newMenuItem = new MenuItem
                    {
                        Name = txtProductName.Text,
                        CategoryID = (Guid)cmbCategory.SelectedValue,
                        Price = Convert.ToDecimal(txtPrice.Text),
                        Description = txtDescription.Text,
                        Image = currentImageData
                    };

                    if (!_menuItemService.IfEntityExists(x => x.Name == newMenuItem.Name))
                    {
                        _menuItemService.Create(newMenuItem);

                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMenuItems();
                    }
                    else
                    {
                        // if the product already exists in the database show a message
                        MessageBox.Show("Product already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                // if the selectedMenuItem is not null, it means that the user is trying to update an existing product
                else
                {
                    selectedMenuItem.Name = txtProductName.Text;
                    selectedMenuItem.CategoryID = (Guid)cmbCategory.SelectedValue;
                    selectedMenuItem.Price = Convert.ToDecimal(txtPrice.Text);
                    selectedMenuItem.Description = txtDescription.Text;
                    selectedMenuItem.Image = currentImageData;
                    _menuItemService.Update(selectedMenuItem);
                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMenuItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    // show the selected image in the picturebox
                    pcbImage.Image = new Bitmap(openFileDialog.FileName);

                    // convert the image to byte array
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
            Program.MainFormInstance.Show();
            this.Hide();
        }
        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            GetAllProducts(txtSearchText.Text.ToLower());
        }

        private void GetAllProducts(string searchText = null)
        {
            List<MenuItem> data;
            if (searchText != null && searchText.Length >= 3)
            {
                // get products by search text
                data = _menuItemService.GetAll().Where(x => x.Name.ToLower().Contains(searchText)
                || x.Category.Name.ToLower().Contains(searchText)).ToList();
            }
            else
            {
                // get all products
                data = _menuItemService.GetAll().ToList();

            }

            // clear datagridview datasource
            dgwProducts.DataSource = null;
            // define new datasource
            dgwProducts.DataSource = data;
        }

        MenuItem? selectedMenuItem;
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // get selected item
            selectedMenuItem = (MenuItem)dgwProducts.CurrentRow.DataBoundItem;
            txtProductName.Text = selectedMenuItem.Name;
            txtDescription.Text = selectedMenuItem.Description;
            txtPrice.Text = selectedMenuItem.Price.ToString();
            cmbCategory.SelectedValue = selectedMenuItem.CategoryID;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes and selectedMenuItem
            txtProductName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            cmbCategory.SelectedIndex = -1;
            selectedMenuItem = null;
            pcbImage.Image = null;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // delete the selected product
            try
            {
                if (selectedMenuItem != null)
                {
                    _menuItemService.Delete(selectedMenuItem.ID);
                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMenuItems();
                }
                else
                {
                    MessageBox.Show("Please select a product to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }
    }
}
