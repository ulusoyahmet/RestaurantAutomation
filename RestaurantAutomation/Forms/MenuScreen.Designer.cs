namespace RestaurantAutomation.UI.Forms
{
    partial class MenuScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewMenu = new DataGridView();
            txtSearchproduct = new TextBox();
            comboBox1 = new ComboBox();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewComboBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colPrice });
            dataGridViewMenu.Location = new Point(7, 28);
            dataGridViewMenu.Margin = new Padding(2, 2, 2, 2);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowHeadersWidth = 82;
            dataGridViewMenu.Size = new Size(882, 188);
            dataGridViewMenu.TabIndex = 0;
            dataGridViewMenu.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearchproduct
            // 
            txtSearchproduct.Location = new Point(7, 238);
            txtSearchproduct.Margin = new Padding(2, 2, 2, 2);
            txtSearchproduct.Name = "txtSearchproduct";
            txtSearchproduct.PlaceholderText = "Search Product";
            txtSearchproduct.Size = new Size(125, 27);
            txtSearchproduct.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(322, 238);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 28);
            comboBox1.TabIndex = 2;
            // 
            // colName
            // 
            colName.HeaderText = "Product Name";
            colName.MinimumWidth = 10;
            colName.Name = "colName";
            colName.Resizable = DataGridViewTriState.True;
            colName.Width = 400;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts", "Snacks" });
            colCategory.MinimumWidth = 10;
            colCategory.Name = "colCategory";
            colCategory.Width = 200;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 10;
            colPrice.Name = "colPrice";
            colPrice.Width = 200;
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 471);
            Controls.Add(comboBox1);
            Controls.Add(txtSearchproduct);
            Controls.Add(dataGridViewMenu);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MenuScreen";
            Text = "MenuScreen";
            Load += MenuScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMenu;
        private TextBox txtSearchproduct;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewComboBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
    }
}