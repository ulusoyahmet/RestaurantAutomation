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
            dataGridView1 = new DataGridView();
            cmbTableName = new ComboBox();
            btnUpdateTable = new Button();
            btnListTables = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            label1 = new Label();
            Name = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnMainMenu = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 432);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Status, Order });
            dataGridView1.Location = new Point(346, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(245, 343);
            dataGridView1.TabIndex = 4;
            // 
            // cmbTableName
            // 
            cmbTableName.FormattingEnabled = true;
            cmbTableName.Location = new Point(115, 60);
            cmbTableName.Name = "cmbTableName";
            cmbTableName.Size = new Size(121, 23);
            cmbTableName.TabIndex = 3;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(167, 341);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(132, 35);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Update Table";
            btnUpdateTable.UseVisualStyleBackColor = true;
            // 
            // btnListTables
            // 
            btnListTables.Location = new Point(29, 382);
            btnListTables.Name = "btnListTables";
            btnListTables.Size = new Size(132, 35);
            btnListTables.TabIndex = 2;
            btnListTables.Text = "Show Table List";
            btnListTables.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(167, 382);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(132, 35);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Delete Table";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(29, 341);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(132, 35);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "Add New Table";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 63);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Table:";
            // 
            // Name
            // 
            Name.FillWeight = 250F;
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.Width = 50;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 50;
            // 
            // Order
            // 
            Order.HeaderText = "Order";
            Order.Name = "Order";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(346, 406);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 5;
            label2.Text = "Available";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(0, 8);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(31, 30);
            btnMainMenu.TabIndex = 2;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.Location = new Point(420, 406);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Occupied";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Gold;
            label4.Location = new Point(512, 406);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 5;
            label4.Text = "Reserved";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 450);
            Controls.Add(groupBox1);
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
    }
}