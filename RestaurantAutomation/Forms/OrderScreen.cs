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
    public partial class OrderScreen : Form
    {
        public OrderScreen()
        {
            InitializeComponent();
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
    }
}
