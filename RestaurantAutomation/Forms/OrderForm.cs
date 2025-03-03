using RestaurantAutomation.Business.Services;
using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation.UI.Forms
{
    public partial class OrderForm : Form
    {
        private readonly MenuItemRepository _menuItemRepo;
        private readonly MenuItemService _menuItemService;
        public OrderForm()
        {
            InitializeComponent();
            AppDbContext appDb = new AppDbContext();
            _menuItemRepo = new MenuItemRepository(appDb);
            _menuItemService = new MenuItemService(_menuItemRepo);
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {
            //GetAllIcicekler
            //GetAllYemekler

            //yiyecek yada içecek

            //var result = productRepo.GetProductCategory(categoryId);
            //lits->ekmek(count payment),kebap(count payment)
            ////yiyecekler / içecekler

            //for (int i = 0; i < result.count; i++)
            //{
            //    //lokasyon büyüklük name text
            //    Button button = new Button();
            //    button.Name = Button + result[i].Name;
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.Show();
            this.Hide();
        }

        private void btnStarters_Click(object sender, EventArgs e)
        {
            try
            {
                var urunlerForm = new Form
                {
                    Text = "Starter Menüsü",
                    Size = new Size(600, 500),
                    StartPosition = FormStartPosition.CenterScreen,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                Guid startersGuid = new Guid("8303b55e-57f6-4108-b52a-ad5864a67729");
                var starters = _menuItemRepo.GetByID(startersGuid);


                for (int i = 0; i < 5; i++)
                {
                    Button productButton = new Button();
                    productButton.Text = $"Ürün {i + 1}";
                    productButton.Size = new System.Drawing.Size(200, 30);
                    productButton.Location = new System.Drawing.Point(50, 20 + (i * 40));

                    // Butona tıklanınca bir işlem yapmak istersen:
                    productButton.Click += (s, ev) => MessageBox.Show($"Ürün siparişe eklendi.");

                    urunlerForm.Controls.Add(productButton);
                }
                btnStarters.Click += (s, e) => MessageBox.Show($"{starters}");
                urunlerForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
