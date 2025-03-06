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
            label3 = new Label();
            label2 = new Label();
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
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
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
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.Location = new Point(562, 50);
            label3.Name = "label3";
            label3.Size = new Size(119, 27);
            label3.TabIndex = 5;
            label3.Text = "Occupied";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LawnGreen;
            label2.Location = new Point(436, 50);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 5;
            label2.Text = "Available";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(5, 80);
            flowLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(677, 348);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(6, 508);
            btnUpdateTable.Margin = new Padding(3, 4, 3, 4);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(135, 60);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Update Table Status";
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
            btnJumptoOrder.Location = new Point(160, 508);
            btnJumptoOrder.Margin = new Padding(3, 4, 3, 4);
            btnJumptoOrder.Name = "btnJumptoOrder";
            btnJumptoOrder.Size = new Size(135, 60);
            btnJumptoOrder.TabIndex = 2;
            btnJumptoOrder.Text = "Jump to Order";
            btnJumptoOrder.UseVisualStyleBackColor = true;
            btnJumptoOrder.Click += btnJumptoOrder_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(160, 435);
            btnDeleteTable.Margin = new Padding(3, 4, 3, 4);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(135, 60);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Delete Table";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(6, 435);
            btnAddTable.Margin = new Padding(3, 4, 3, 4);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(135, 60);
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
    }
}