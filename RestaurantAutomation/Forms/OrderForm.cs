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
        private Guid? _currentTableId = null;
        private DataTable _orderItemsTable;
        //private Guid _currentOrderId;
        //private DataTable _orderItemsTable;
        //private decimal _totalAmount = 0;

        public OrderForm()
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
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Program.MainFormInstance.Show();
            this.Hide();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStarters_Click(object sender, EventArgs e)
        {
            ShowCategoryItems("Starters");
        }

        private void ShowCategoryItems(string categoryName)
        {
            var category = _categoryService.GetAll().FirstOrDefault(c => c.Name == categoryName);
            if (category == null) return;

            //Yeni form oluştur:          

            Form menuItemsForm = new Form()
            {
                Text = categoryName,
                Size = new Size(400, 600),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            FlowLayoutPanel panel = new FlowLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10)
            };
            menuItemsForm.Controls.Add(panel);

            // Veriyi al ve kategoriye göre filtrele
            var menuItems = _menuItemService.GetAll().Where(m => m.CategoryID == category.ID);


            foreach (var item in menuItems)
            {
                Button menuItemButton = new Button()
                {
                    Text = $"{item.Name}\n{item.Price:C2}",
                    Tag = item,
                    Width = 120,
                    Height = 50
                };
                menuItemButton.Click += (sender, e) =>
                {
                    AddToOrder((MenuItem)((Button)sender).Tag);
                    menuItemsForm.Close();
                };
                panel.Controls.Add(menuItemButton);
            }
            menuItemsForm.Show();

        }

        private void AddToOrder(MenuItem tag)
        {
            int quantity = 1;
            decimal totalPrice = tag.Price * quantity;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewButtonCell() { Value = "Sil" });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = tag.Name });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = quantity });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = tag.Price });
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = totalPrice });

            dataGridView1.Rows.Add(row);
        }
    }
}
