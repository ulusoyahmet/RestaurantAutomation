using Guna.UI2.WinForms;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new Guna2GroupBox();
            label3 = new Guna2HtmlLabel();
            label2 = new Guna2HtmlLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnUpdateTable = new Guna2Button();
            btnMainMenu = new Guna2Button();
            btnJumptoOrder = new Guna2Button();
            btnDeleteTable = new Guna2Button();
            btnAddTable = new Guna2Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BorderColor = Color.Transparent;
            groupBox1.BorderRadius = 20;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(btnUpdateTable);
            groupBox1.Controls.Add(btnJumptoOrder);
            groupBox1.Controls.Add(btnDeleteTable);
            groupBox1.Controls.Add(btnAddTable);
            groupBox1.CustomBorderColor = Color.FromArgb(12, 155, 193);
            groupBox1.CustomizableEdges = customizableEdges9;
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(265, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            groupBox1.Size = new Size(611, 472);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tables";
            // 
            // label3
            // 
            label3.BackColor = Color.Red;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(429, 55);
            label3.Name = "label3";
            label3.Size = new Size(77, 27);
            label3.TabIndex = 5;
            label3.Text = "Occupied";
            label3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LawnGreen;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(512, 55);
            label2.Name = "label2";
            label2.Size = new Size(73, 27);
            label2.TabIndex = 5;
            label2.Text = "Available";
            label2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(4, 87);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(581, 256);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.BorderColor = Color.Transparent;
            btnUpdateTable.BorderRadius = 20;
            btnUpdateTable.CustomizableEdges = customizableEdges1;
            btnUpdateTable.FillColor = Color.FromArgb(12, 155, 193);
            btnUpdateTable.Font = new Font("Segoe UI", 9F);
            btnUpdateTable.ForeColor = Color.White;
            btnUpdateTable.Location = new Point(318, 348);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUpdateTable.Size = new Size(118, 45);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Update Status";
            btnUpdateTable.Click += btnUpdateTable_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.Transparent;
            btnMainMenu.BorderColor = Color.Transparent;
            btnMainMenu.BorderRadius = 1;
            btnMainMenu.CustomizableEdges = customizableEdges11;
            btnMainMenu.FillColor = Color.FromArgb(12, 155, 193);
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Location = new Point(12, 12);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnMainMenu.Size = new Size(38, 30);
            btnMainMenu.TabIndex = 2;
            btnMainMenu.Text = "🡰";
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnJumptoOrder
            // 
            btnJumptoOrder.BorderColor = Color.Transparent;
            btnJumptoOrder.BorderRadius = 20;
            btnJumptoOrder.CustomizableEdges = customizableEdges3;
            btnJumptoOrder.FillColor = Color.FromArgb(12, 155, 193);
            btnJumptoOrder.Font = new Font("Segoe UI", 9F);
            btnJumptoOrder.ForeColor = Color.White;
            btnJumptoOrder.Location = new Point(467, 348);
            btnJumptoOrder.Name = "btnJumptoOrder";
            btnJumptoOrder.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnJumptoOrder.Size = new Size(118, 45);
            btnJumptoOrder.TabIndex = 2;
            btnJumptoOrder.Text = "Jump to Order";
            btnJumptoOrder.Click += btnJumptoOrder_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.BorderColor = Color.Transparent;
            btnDeleteTable.BorderRadius = 20;
            btnDeleteTable.CustomizableEdges = customizableEdges5;
            btnDeleteTable.FillColor = Color.FromArgb(12, 155, 193);
            btnDeleteTable.Font = new Font("Segoe UI", 9F);
            btnDeleteTable.ForeColor = Color.White;
            btnDeleteTable.Location = new Point(161, 348);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDeleteTable.Size = new Size(118, 45);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Delete Table";
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnAddTable
            // 
            btnAddTable.BorderColor = Color.Transparent;
            btnAddTable.BorderRadius = 20;
            btnAddTable.CustomizableEdges = customizableEdges7;
            btnAddTable.FillColor = Color.FromArgb(12, 155, 193);
            btnAddTable.Font = new Font("Segoe UI", 9F);
            btnAddTable.ForeColor = Color.White;
            btnAddTable.Location = new Point(4, 348);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddTable.Size = new Size(118, 45);
            btnAddTable.TabIndex = 2;
            btnAddTable.Text = "Add New Table";
            btnAddTable.Click += btnAddTable_Click;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 773);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(btnMainMenu);
            Name = "TableForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Table Screen";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna2GroupBox groupBox1;
        private Guna2Button btnUpdateTable;
        private Guna2Button btnJumptoOrder;
        private Guna2Button btnDeleteTable;
        private Guna2Button btnAddTable;
        private Guna2HtmlLabel label2;
        private Guna2Button btnMainMenu;
        private Guna2HtmlLabel label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox lstAddition;
        private ListBox lstOrders;
        private Guna2HtmlLabel label6;
        private Guna2HtmlLabel label4;
        private Guna2HtmlLabel lblTotal;
        private Guna2HtmlLabel label7;
    }
}