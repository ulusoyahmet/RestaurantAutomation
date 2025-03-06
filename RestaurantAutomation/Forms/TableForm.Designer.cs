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
            lblTotal = new Label();
            label7 = new Label();
            lstAddition = new ListBox();
            lstOrders = new ListBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnUpdateTable = new Button();
            btnMainMenu = new Button();
            btnJumptoOrder = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lstAddition);
            groupBox1.Controls.Add(lstOrders);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(btnUpdateTable);
            groupBox1.Controls.Add(btnMainMenu);
            groupBox1.Controls.Add(btnJumptoOrder);
            groupBox1.Controls.Add(btnDeleteTable);
            groupBox1.Controls.Add(btnAddTable);
            groupBox1.Location = new Point(14, 8);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(711, 576);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(565, 429);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "00000000 ₺";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(518, 429);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 11;
            label7.Text = "Total:";
            // 
            // lstAddition
            // 
            lstAddition.FormattingEnabled = true;
            lstAddition.Location = new Point(518, 104);
            lstAddition.Margin = new Padding(2, 3, 2, 3);
            lstAddition.Name = "lstAddition";
            lstAddition.Size = new Size(174, 324);
            lstAddition.TabIndex = 10;
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.Location = new Point(334, 103);
            lstOrders.Margin = new Padding(2, 3, 2, 3);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(162, 344);
            lstOrders.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 83);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 9;
            label6.Text = "Addition:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 79);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 9;
            label4.Text = "Order Items:";
            // 
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.Location = new Point(38, 51);
            label3.Name = "label3";
            label3.Size = new Size(119, 27);
            label3.TabIndex = 5;
            label3.Text = "Occupied";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 8;
            label5.Text = "Waiter Table Panel";
            label5.Visible = false;
            // 
            // label2
            // 
            label2.BackColor = Color.LawnGreen;
            label2.Location = new Point(182, 51);
            label2.Name = "label2";
            label2.Size = new Size(110, 27);
            label2.TabIndex = 5;
            label2.Text = "Available";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 7;
            label1.Text = "Admin Table Panel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(33, 80);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(282, 368);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(182, 456);
            btnUpdateTable.Margin = new Padding(3, 4, 3, 4);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(133, 40);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Update Table";
            btnUpdateTable.UseVisualStyleBackColor = true;
            btnUpdateTable.Click += btnUpdateTable_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(0, 11);
            btnMainMenu.Margin = new Padding(3, 4, 3, 4);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(35, 40);
            btnMainMenu.TabIndex = 2;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnJumptoOrder
            // 
            btnJumptoOrder.Location = new Point(182, 504);
            btnJumptoOrder.Margin = new Padding(3, 4, 3, 4);
            btnJumptoOrder.Name = "btnJumptoOrder";
            btnJumptoOrder.Size = new Size(133, 40);
            btnJumptoOrder.TabIndex = 2;
            btnJumptoOrder.Text = "Jump to Order";
            btnJumptoOrder.UseVisualStyleBackColor = true;
            btnJumptoOrder.Click += btnJumptoOrder_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(32, 504);
            btnDeleteTable.Margin = new Padding(3, 4, 3, 4);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(133, 40);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Delete Table";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(32, 456);
            btnAddTable.Margin = new Padding(3, 4, 3, 4);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(133, 44);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "Add New Table";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 600);
            ControlBox = false;
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TableForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Table Screen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdateTable;
        private Button btnJumptoOrder;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Label label2;
        private Button btnMainMenu;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label5;
        private ListBox lstAddition;
        private ListBox lstOrders;
        private Label label6;
        private Label label4;
        private Label lblTotal;
        private Label label7;
    }
}