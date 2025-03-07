namespace RestaurantAutomation.UI.Forms
{
    partial class LoginForm
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
            GroupBox groupBox1;
            cmbRoles = new ComboBox();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            btnSignIn = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbRoles);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(btnSignIn);
            groupBox1.Location = new Point(15, 16);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(514, 375);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // cmbRoles
            // 
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(170, 81);
            cmbRoles.Margin = new Padding(4, 5, 4, 5);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(253, 33);
            cmbRoles.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 5;
            label1.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(170, 191);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(253, 31);
            txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(170, 139);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(253, 31);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(76, 196);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(76, 144);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(170, 256);
            btnSignIn.Margin = new Padding(4, 5, 4, 5);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(254, 50);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In / Sign Up";
            btnSignIn.Click += btnSignIn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 419);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up / Login";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSignIn;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private ComboBox cmbRoles;
        private Label label1;
    }
}