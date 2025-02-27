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
    public partial class TableScreen : Form
    {
        public TableScreen()
        {
            InitializeComponent();

            for (int i = 0; i < 19; i++)
            {
                Button b = new Button();
                b.Text = "Table " + i;
                b.Size = new Size(100, 100);
                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
