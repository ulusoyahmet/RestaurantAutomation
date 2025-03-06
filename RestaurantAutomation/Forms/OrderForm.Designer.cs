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
            btnMainMenu = new Button();
            label1 = new Label();
            lblOrderStatus = new Label();
            lblTotalAmount = new Label();
            lblOrderNotes = new Label();
            btnStarters = new Button();
            btnMainCourses = new Button();
            btnDesserts = new Button();
            btnBeverages = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewButtonColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnCompleteOrder = new Button();
            btnCancelOrder = new Button();
            btnPayment = new Button();
            btnAddNote = new Button();
            btnOrderHistory = new Button();
            nmrTable = new NumericUpDown();
            label2 = new Label();
            cmbTableNo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrTable).BeginInit();
            SuspendLayout();
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(12, 12);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(45, 28);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "🡰";
            btnMainMenu.TextAlign = ContentAlignment.TopCenter;
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Table No:";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(152, 59);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(52, 20);
            lblOrderStatus.TabIndex = 1;
            lblOrderStatus.Text = "Status:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(293, 59);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(45, 20);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "Total:";
            // 
            // lblOrderNotes
            // 
            lblOrderNotes.AutoSize = true;
            lblOrderNotes.Location = new Point(449, 59);
            lblOrderNotes.Name = "lblOrderNotes";
            lblOrderNotes.Size = new Size(45, 20);
            lblOrderNotes.TabIndex = 1;
            lblOrderNotes.Text = "Note:";
            // 
            // btnStarters
            // 
            btnStarters.Location = new Point(12, 106);
            btnStarters.Name = "btnStarters";
            btnStarters.Size = new Size(107, 29);
            btnStarters.TabIndex = 2;
            btnStarters.Text = "Starters";
            btnStarters.UseVisualStyleBackColor = true;
            btnStarters.Click += btnStarters_Click;
            // 
            // btnMainCourses
            // 
            btnMainCourses.Location = new Point(12, 153);
            btnMainCourses.Name = "btnMainCourses";
            btnMainCourses.Size = new Size(107, 29);
            btnMainCourses.TabIndex = 2;
            btnMainCourses.Text = "Main Courses";
            btnMainCourses.UseVisualStyleBackColor = true;
            btnMainCourses.Click += btnMainCourses_Click;
            // 
            // btnDesserts
            // 
            btnDesserts.Location = new Point(12, 199);
            btnDesserts.Name = "btnDesserts";
            btnDesserts.Size = new Size(107, 29);
            btnDesserts.TabIndex = 2;
            btnDesserts.Text = "Desserts";
            btnDesserts.UseVisualStyleBackColor = true;
            btnDesserts.Click += btnDesserts_Click;
            // 
            // btnBeverages
            // 
            btnBeverages.Location = new Point(12, 247);
            btnBeverages.Name = "btnBeverages";
            btnBeverages.Size = new Size(109, 29);
            btnBeverages.TabIndex = 2;
            btnBeverages.Text = "Beverages";
            btnBeverages.UseVisualStyleBackColor = true;
            btnBeverages.Click += btnBeverages_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(152, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(471, 201);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Delete";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.HeaderText = "ProductName";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.FillWeight = 50F;
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 75;
            // 
            // Column4
            // 
            Column4.FillWeight = 50F;
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 60;
            // 
            // Column5
            // 
            Column5.FillWeight = 50F;
            Column5.HeaderText = "TotalPrice";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 80;
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.Location = new Point(12, 340);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(94, 48);
            btnCompleteOrder.TabIndex = 2;
            btnCompleteOrder.Text = "Complete Order";
            btnCompleteOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(142, 340);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(94, 48);
            btnCancelOrder.TabIndex = 2;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(265, 340);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(94, 48);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnAddNote
            // 
            btnAddNote.Location = new Point(385, 340);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(94, 48);
            btnAddNote.TabIndex = 2;
            btnAddNote.Text = "Add Note";
            btnAddNote.UseVisualStyleBackColor = true;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.Location = new Point(510, 340);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Size = new Size(94, 48);
            btnOrderHistory.TabIndex = 2;
            btnOrderHistory.Text = "Order History";
            btnOrderHistory.UseVisualStyleBackColor = true;
            // 
            // nmrTable
            // 
            nmrTable.Location = new Point(89, 17);
            nmrTable.Name = "nmrTable";
            nmrTable.Size = new Size(44, 27);
            nmrTable.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(202, 12);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 5;
            label2.Text = "Order Management";
            // 
            // cmbTableNo
            // 
            cmbTableNo.FormattingEnabled = true;
            cmbTableNo.Location = new Point(83, 56);
            cmbTableNo.Name = "cmbTableNo";
            cmbTableNo.Size = new Size(50, 28);
            cmbTableNo.TabIndex = 6;
            cmbTableNo.SelectedIndexChanged += cmbTableNo_SelectedIndexChanged;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 399);
            Controls.Add(cmbTableNo);
            Controls.Add(label2);
            Controls.Add(nmrTable);
            Controls.Add(dataGridView1);
            Controls.Add(btnOrderHistory);
            Controls.Add(btnAddNote);
            Controls.Add(btnPayment);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnCompleteOrder);
            Controls.Add(btnBeverages);
            Controls.Add(btnDesserts);
            Controls.Add(btnMainCourses);
            Controls.Add(btnStarters);
            Controls.Add(lblOrderNotes);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblOrderStatus);
            Controls.Add(label1);
            Controls.Add(btnMainMenu);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMainMenu;
        private Label label1;
        private Label lblOrderStatus;
        private Label lblTotalAmount;
        private Label lblOrderNotes;
        private Button btnStarters;
        private Button btnMainCourses;
        private Button btnDesserts;
        private Button btnBeverages;
        private DataGridView dataGridView1;
        private Button btnCompleteOrder;
        private Button btnCancelOrder;
        private Button btnPayment;
        private Button btnAddNote;
        private Button btnOrderHistory;
        private NumericUpDown nmrTable;
        private Label label2;
        private DataGridViewButtonColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox cmbTableNo;
    }
}