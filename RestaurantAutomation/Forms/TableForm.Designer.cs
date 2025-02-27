namespace RestaurantAutomation.UI.Forms
{
    partial class TableForm
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
            label5 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            btnUpdateTable = new Button();
            btnMainMenu = new Button();
            btnListTables = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnUpdateTable);
            groupBox1.Controls.Add(btnMainMenu);
            groupBox1.Controls.Add(btnListTables);
            groupBox1.Controls.Add(btnDeleteTable);
            groupBox1.Controls.Add(btnAddTable);
            groupBox1.Location = new Point(17, 10);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(889, 720);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 66);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 8;
            label5.Text = "Waiter Table Panel";
            label5.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 68);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 7;
            label1.Text = "Admin Table Panel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(41, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(406, 460);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.Location = new Point(680, 677);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 33);
            label3.TabIndex = 5;
            label3.Text = "Occupied";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.GreenYellow;
            label2.Location = new Point(494, 677);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 33);
            label2.TabIndex = 5;
            label2.Text = "Available";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Status, Order });
            dataGridView1.Location = new Point(494, 100);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(350, 572);
            dataGridView1.TabIndex = 4;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Name.FillWeight = 383.522736F;
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 95;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Status.FillWeight = 33.2386322F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 96;
            // 
            // Order
            // 
            Order.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Order.FillWeight = 33.2386322F;
            Order.HeaderText = "Order";
            Order.MinimumWidth = 8;
            Order.Name = "Order";
            Order.Width = 94;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(258, 568);
            btnUpdateTable.Margin = new Padding(4, 5, 4, 5);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(189, 58);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Update Table";
            btnUpdateTable.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(0, 13);
            btnMainMenu.Margin = new Padding(4, 5, 4, 5);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(44, 50);
            btnMainMenu.TabIndex = 2;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnListTables
            // 
            btnListTables.Location = new Point(41, 637);
            btnListTables.Margin = new Padding(4, 5, 4, 5);
            btnListTables.Name = "btnListTables";
            btnListTables.Size = new Size(189, 58);
            btnListTables.TabIndex = 2;
            btnListTables.Text = "Show Table List";
            btnListTables.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(258, 637);
            btnDeleteTable.Margin = new Padding(4, 5, 4, 5);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(189, 58);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Delete Table";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(41, 569);
            btnAddTable.Margin = new Padding(4, 5, 4, 5);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(189, 58);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "Add New Table";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 750);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);            
            Text = "Table Screen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdateTable;
        private Button btnListTables;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btnMainMenu;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Order;
        private Label label1;
        private Label label5;
    }
}