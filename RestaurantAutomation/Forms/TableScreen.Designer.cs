namespace RestaurantAutomation.UI.Forms
{
    partial class TableScreen
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
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            cmbTableName = new ComboBox();
            btnUpdateTable = new Button();
            btnMainMenu = new Button();
            btnListTables = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(cmbTableName);
            groupBox1.Controls.Add(btnUpdateTable);
            groupBox1.Controls.Add(btnMainMenu);
            groupBox1.Controls.Add(btnListTables);
            groupBox1.Controls.Add(btnDeleteTable);
            groupBox1.Controls.Add(btnAddTable);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 8);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(711, 576);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(33, 113);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(310, 335);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.BackColor = Color.Gold;
            label4.Location = new Point(585, 542);
            label4.Name = "label4";
            label4.Size = new Size(90, 26);
            label4.TabIndex = 5;
            label4.Text = "Reserved";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.Location = new Point(480, 542);
            label3.Name = "label3";
            label3.Size = new Size(98, 26);
            label3.TabIndex = 5;
            label3.Text = "Occupied";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(395, 542);
            label2.Name = "label2";
            label2.Size = new Size(78, 26);
            label2.TabIndex = 5;
            label2.Text = "Available";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Status, Order });
            dataGridView1.Location = new Point(395, 80);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(310, 458);
            dataGridView1.TabIndex = 4;
            // 
            // Name
            // 
            Name.FillWeight = 250F;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 50;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 50;
            // 
            // Order
            // 
            Order.HeaderText = "Order";
            Order.MinimumWidth = 8;
            Order.Name = "Order";
            Order.Width = 150;
            // 
            // cmbTableName
            // 
            cmbTableName.FormattingEnabled = true;
            cmbTableName.Location = new Point(131, 80);
            cmbTableName.Margin = new Padding(3, 4, 3, 4);
            cmbTableName.Name = "cmbTableName";
            cmbTableName.Size = new Size(138, 28);
            cmbTableName.TabIndex = 3;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(191, 454);
            btnUpdateTable.Margin = new Padding(3, 4, 3, 4);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(151, 46);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Update Table";
            btnUpdateTable.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(0, 10);
            btnMainMenu.Margin = new Padding(3, 4, 3, 4);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(35, 40);
            btnMainMenu.TabIndex = 2;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnListTables
            // 
            btnListTables.Location = new Point(33, 510);
            btnListTables.Margin = new Padding(3, 4, 3, 4);
            btnListTables.Name = "btnListTables";
            btnListTables.Size = new Size(151, 46);
            btnListTables.TabIndex = 2;
            btnListTables.Text = "Show Table List";
            btnListTables.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(191, 510);
            btnDeleteTable.Margin = new Padding(3, 4, 3, 4);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(151, 46);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Delete Table";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(33, 454);
            btnAddTable.Margin = new Padding(3, 4, 3, 4);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(151, 46);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "Add New Table";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 84);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Select Table:";
            // 
            // TableScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 692);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);           
            Text = "TableScreen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbTableName;
        private Button btnUpdateTable;
        private Button btnListTables;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Order;
        private Label label2;
        private Button btnMainMenu;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}