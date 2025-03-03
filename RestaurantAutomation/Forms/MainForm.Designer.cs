namespace RestaurantAutomation.UI.Forms
{
    partial class MainForm
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
            btnReports = new Button();
            btnMenu = new Button();
            btnOrder = new Button();
            btnTable = new Button();
            btnLogin = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReports);
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnTable);
            groupBox1.Location = new Point(124, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 299);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnReports
            // 
            btnReports.Location = new Point(262, 131);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(203, 67);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(53, 131);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(203, 67);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu Management";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(262, 57);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(203, 67);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Order Management";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnTable
            // 
            btnTable.Location = new Point(53, 57);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(203, 67);
            btnTable.TabIndex = 6;
            btnTable.Text = "Table Management";
            btnTable.UseVisualStyleBackColor = true;
            btnTable.Click += btnTable_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(12, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(31, 30);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "🡰";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 467);
            Controls.Add(btnLogin);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "MainScreen";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnReports;
        private Button btnMenu;
        private Button btnOrder;
        private Button btnTable;
        private Button btnLogin;
    }
}