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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dgwCancel = new DataGridViewTextBoxColumn();
            dgwProductName = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewComboBoxColumn();
            dgwUnitPrice = new DataGridViewTextBoxColumn();
            dgwAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(886, 115);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(121, 118);
            button1.TabIndex = 4;
            button1.Text = "Yiyecek";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1041, 115);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(121, 118);
            button2.TabIndex = 5;
            button2.Text = "İçecek";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgwCancel, dgwProductName, Column1, dgwUnitPrice, dgwAmount });
            dataGridView1.Location = new Point(15, 101);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(759, 361);
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
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 789);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "OrderScreen";
            Text = "OrderScreen";
            Load += OrderScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dgwCancel;
        private DataGridViewTextBoxColumn dgwProductName;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewTextBoxColumn dgwUnitPrice;
        private DataGridViewTextBoxColumn dgwAmount;
    }
}