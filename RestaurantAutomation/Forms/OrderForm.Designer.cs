namespace RestaurantAutomation.UI.Forms
{
    partial class OrderForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnMainCourses = new Button();
            btnStarters = new Button();
            categoryBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            dgwCancel = new DataGridViewTextBoxColumn();
            dgwProductName = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewComboBoxColumn();
            dgwUnitPrice = new DataGridViewTextBoxColumn();
            dgwAmount = new DataGridViewTextBoxColumn();
            dgwDate = new DataGridViewTextBoxColumn();
            btnBeverages = new Button();
            btnDesserts = new Button();
            btnSaveOrder = new Button();
            dataGridView2 = new DataGridView();
            btnNewOrder = new Button();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnMainCourses
            // 
            btnMainCourses.Location = new Point(999, 202);
            btnMainCourses.Margin = new Padding(4);
            btnMainCourses.Name = "btnMainCourses";
            btnMainCourses.Size = new Size(172, 88);
            btnMainCourses.TabIndex = 4;
            btnMainCourses.Text = "Main Courses";
            btnMainCourses.UseVisualStyleBackColor = true;
            // 
            // btnStarters
            // 
            btnStarters.Location = new Point(999, 62);
            btnStarters.Margin = new Padding(4);
            btnStarters.Name = "btnStarters";
            btnStarters.Size = new Size(172, 88);
            btnStarters.TabIndex = 5;
            btnStarters.Text = "Starters...";
            btnStarters.UseVisualStyleBackColor = true;
            btnStarters.Click += btnStarters_Click;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Entities.Models.Category);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgwCancel, dgwProductName, Column1, dgwUnitPrice, dgwAmount, dgwDate });
            dataGridView1.Location = new Point(15, 62);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 198);
            dataGridView1.TabIndex = 6;
            // 
            // dgwCancel
            // 
            dgwCancel.HeaderText = "İptal";
            dgwCancel.MinimumWidth = 6;
            dgwCancel.Name = "dgwCancel";
            dgwCancel.Width = 50;
            // 
            // dgwProductName
            // 
            dgwProductName.HeaderText = "Ürün Adı";
            dgwProductName.MinimumWidth = 6;
            dgwProductName.Name = "dgwProductName";
            dgwProductName.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Miktar";
            Column1.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // dgwUnitPrice
            // 
            dataGridViewCellStyle2.NullValue = "0";
            dgwUnitPrice.DefaultCellStyle = dataGridViewCellStyle2;
            dgwUnitPrice.HeaderText = "Fiyat";
            dgwUnitPrice.MinimumWidth = 6;
            dgwUnitPrice.Name = "dgwUnitPrice";
            dgwUnitPrice.Width = 125;
            // 
            // dgwAmount
            // 
            dgwAmount.HeaderText = "Tutar";
            dgwAmount.MinimumWidth = 6;
            dgwAmount.Name = "dgwAmount";
            dgwAmount.Width = 125;
            // 
            // dgwDate
            // 
            dgwDate.HeaderText = "Sipariş Tarihi";
            dgwDate.MinimumWidth = 6;
            dgwDate.Name = "dgwDate";
            dgwDate.Width = 125;
            // 
            // btnBeverages
            // 
            btnBeverages.Location = new Point(999, 482);
            btnBeverages.Margin = new Padding(4);
            btnBeverages.Name = "btnBeverages";
            btnBeverages.Size = new Size(172, 90);
            btnBeverages.TabIndex = 7;
            btnBeverages.Text = "Beverages";
            btnBeverages.UseVisualStyleBackColor = true;
            // 
            // btnDesserts
            // 
            btnDesserts.Location = new Point(999, 340);
            btnDesserts.Margin = new Padding(4);
            btnDesserts.Name = "btnDesserts";
            btnDesserts.Size = new Size(172, 90);
            btnDesserts.TabIndex = 7;
            btnDesserts.Text = "Desserts";
            btnDesserts.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(749, 284);
            btnSaveOrder.Margin = new Padding(4);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(210, 49);
            btnSaveOrder.TabIndex = 8;
            btnSaveOrder.Text = "Sipariş Kaydet";
            btnSaveOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 357);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(944, 215);
            dataGridView2.TabIndex = 9;
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(15, 284);
            btnNewOrder.Margin = new Padding(4);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(210, 49);
            btnNewOrder.TabIndex = 10;
            btnNewOrder.Text = "Yeni Sipariş";
            btnNewOrder.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(15, 3);
            btnMainMenu.Margin = new Padding(4, 5, 4, 5);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(44, 50);
            btnMainMenu.TabIndex = 11;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 574);
            Controls.Add(btnMainMenu);
            Controls.Add(btnNewOrder);
            Controls.Add(dataGridView2);
            Controls.Add(btnSaveOrder);
            Controls.Add(btnDesserts);
            Controls.Add(btnBeverages);
            Controls.Add(dataGridView1);
            Controls.Add(btnStarters);
            Controls.Add(btnMainCourses);
            Margin = new Padding(4);
            Name = "OrderForm";
            Text = "OrderScreen";
            Load += OrderScreen_Load;
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMainCourses;
        private Button btnStarters;
        private DataGridView dataGridView1;
        private Button btnBeverages;
        private Button btnDesserts;
        private Button btnSaveOrder;
        private DataGridView dataGridView2;
        private Button btnNewOrder;
        private Button btnMainMenu;
        private DataGridViewTextBoxColumn dgwCancel;
        private DataGridViewTextBoxColumn dgwProductName;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewTextBoxColumn dgwUnitPrice;
        private DataGridViewTextBoxColumn dgwAmount;
        private DataGridViewTextBoxColumn dgwDate;
        private BindingSource categoryBindingSource;
    }
}