namespace RestaurantAutomation.UI.Forms
{
    partial class ReportForm
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
            SuspendLayout();
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(14, 15);
            btnMainMenu.Margin = new Padding(5, 6, 5, 6);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(57, 64);
            btnMainMenu.TabIndex = 11;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 787);
            Controls.Add(btnMainMenu);
            Name = "ReportForm";
            Text = "ReportScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainMenu;
    }
}