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
            btnCustomer = new Button();
            btnOrder = new Button();
            btnTable = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReports);
            groupBox1.Controls.Add(btnMenu);
            groupBox1.Controls.Add(btnCustomer);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(btnTable);
            groupBox1.Location = new Point(39, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 299);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnReports
            // 
            btnReports.Location = new Point(158, 203);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(203, 67);
            btnReports.TabIndex = 2;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(262, 130);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(203, 67);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "Menu Management";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(53, 130);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(203, 67);
            btnCustomer.TabIndex = 4;
            btnCustomer.Text = "Customer Management";
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(262, 57);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(203, 67);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "Order Management";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnTable
            // 
            btnTable.Location = new Point(53, 57);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(203, 67);
            btnTable.TabIndex = 6;
            btnTable.Text = "Table Management";
            btnTable.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 326);
            Controls.Add(groupBox1);
            Name = "MainScreen";
            Text = "MainScreen";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnReports;
        private Button btnMenu;
        private Button btnCustomer;
        private Button btnOrder;
        private Button btnTable;
    }
}