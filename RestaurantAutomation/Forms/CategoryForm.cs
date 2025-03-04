using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.UI.Forms
{
    public partial class CategoryForm : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        private readonly CategoryRepository _categoryRepository;
        private readonly BindingSource _categoryBindingSource = new BindingSource();
        private Category? _selectedCategory;

        public CategoryForm()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository(_dbContext);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load all categories to datagridview
            _categoryBindingSource.DataSource = _categoryRepository.GetAll();
            dataGridView1.DataSource = _categoryBindingSource;

            // Hide all groupboxes
            grpboxAdd.Visible = false;
            grpBoxDelete.Visible = false;
            grpBoxEdit.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmbDeleteCategory.DataSource = _categoryRepository.GetAll();
            _selectedCategory = (Category)cmbDeleteCategory.SelectedItem;

            // Category delete groupbox will be visible
            grpBoxDelete.Visible = true;
            grpboxAdd.Visible = false;
            grpBoxEdit.Visible = false;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            // Delete logic here...
            try
            {
                _categoryBindingSource.DataSource = _categoryRepository.GetAll();
                _selectedCategory = (Category)cmbDeleteCategory.SelectedItem;
                _categoryRepository.Delete(_selectedCategory.ID);
                MessageBox.Show("The category was successfully deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete the category. Error: " + ex.Message);
                throw;
            }
            finally
            {
                _categoryBindingSource.DataSource = _categoryRepository.GetAll();
                cmbDeleteCategory.DataSource = _categoryRepository.GetAll();
                _selectedCategory = (Category)cmbDeleteCategory.SelectedItem;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Category edit groupbox will be visible
            InitializeEditGroupBoxControls();
            grpBoxEdit.Visible = true;
            grpboxAdd.Visible = false;
            grpBoxDelete.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Category adding groupbox will be visible         
            grpboxAdd.Visible = true;
            grpBoxEdit.Visible = false;
            grpBoxDelete.Visible = false;
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Update logic here...
                _selectedCategory.Name = txtEditName.Text;
                _selectedCategory.Description = txtEditDesc.Text;
                _categoryRepository.Update(_selectedCategory);
                _categoryBindingSource.DataSource = _categoryRepository.GetAll();
                MessageBox.Show("The category was successfully updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update the category. Error: \" + ex.Message");
                throw;
            }
        }

        private void cmbEditCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCategory = (Category)cmbEditCategory.SelectedItem;

            if (_selectedCategory != null)
            {
                // Update textbox values
                txtEditName.Text = _selectedCategory.Name;
                txtEditDesc.Text = _selectedCategory.Description;
            }
        }

        private void InitializeEditGroupBoxControls()
        {
            // Clear all controls and reinitialize them
            grpboxAdd.Controls.Clear();
            cmbEditCategory.DataSource = _categoryRepository.GetAll();
            _selectedCategory = (Category)cmbEditCategory.SelectedItem;
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            // Add new category logic here...
            try
            {
                Category newCategory = new Category
                {
                    Name = txtAddName.Text,
                    Description = txtAddDesc.Text
                };
                _categoryRepository.Create(newCategory);
                _categoryBindingSource.DataSource = _categoryRepository.GetAll();
                MessageBox.Show("The category was successfully added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add the category. Error: " + ex.Message);
                throw;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // List all categories
            try
            {
                _categoryBindingSource.DataSource = _categoryRepository.GetAll();
                MessageBox.Show("All categories are listed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
