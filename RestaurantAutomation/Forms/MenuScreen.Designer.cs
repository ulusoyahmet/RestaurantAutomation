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
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewComboBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            txtSearchproduct = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colPrice });
            dataGridViewMenu.Location = new Point(12, 44);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowHeadersWidth = 82;
            dataGridViewMenu.Size = new Size(786, 300);
            dataGridViewMenu.TabIndex = 0;
            dataGridViewMenu.CellContentClick += dataGridView1_CellContentClick;
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
            colCategory.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts", "Snacks", "Beverages" });
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
            // txtSearchproduct
            // 
            txtSearchproduct.Location = new Point(12, 380);
            txtSearchproduct.Name = "txtSearchproduct";
            txtSearchproduct.PlaceholderText = "Search Product";
            txtSearchproduct.Size = new Size(200, 39);
            txtSearchproduct.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(523, 380);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 2;
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 754);
            Controls.Add(comboBox1);
            Controls.Add(txtSearchproduct);
            Controls.Add(dataGridViewMenu);
            Name = "MenuScreen";
            Text = "MenuScreen";
            Load += MenuScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMenu;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewComboBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private TextBox txtSearchproduct;
        private ComboBox comboBox1;
    }
}