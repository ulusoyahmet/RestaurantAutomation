namespace RestaurantAutomation.UI.Forms
{
    partial class OrderScreen
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dgwCancel = new DataGridViewTextBoxColumn();
            dgwProductName = new DataGridViewTextBoxColumn();
            dgwQuantity = new DataGridViewComboBoxColumn();
            dgwUnitPrice = new DataGridViewTextBoxColumn();
            dgwAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(709, 92);
            button1.Name = "button1";
            button1.Size = new Size(97, 94);
            button1.TabIndex = 4;
            button1.Text = "Yiyecek";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(833, 92);
            button2.Name = "button2";
            button2.Size = new Size(97, 94);
            button2.TabIndex = 5;
            button2.Text = "İçecek";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgwCancel, dgwProductName, dgwQuantity, dgwUnitPrice, dgwAmount });
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(607, 289);
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
            // dgwQuantity
            // 
            dgwQuantity.HeaderText = "Miktar";
            dgwQuantity.MinimumWidth = 6;
            dgwQuantity.Name = "dgwQuantity";
            dgwQuantity.Resizable = DataGridViewTriState.True;
            dgwQuantity.SortMode = DataGridViewColumnSortMode.Automatic;
            dgwQuantity.Width = 125;
            // 
            // dgwUnitPrice
            // 
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 631);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private DataGridViewComboBoxColumn dgwQuantity;
        private DataGridViewTextBoxColumn dgwUnitPrice;
        private DataGridViewTextBoxColumn dgwAmount;
    }
}