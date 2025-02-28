namespace RestaurantAutomation.UI.Forms
{
    partial class MenuForm
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
            dgwProducts = new DataGridView();
            txtSearchproduct = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            grpProduct = new GroupBox();
            txtPrice = new TextBox();
            btnUploadImage = new Button();
            label7 = new Label();
            pcbImage = new PictureBox();
            label6 = new Label();
            txtDescription = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbCategory = new ComboBox();
            txtProductName = new TextBox();
            btnAdd = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImage).BeginInit();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(9, 68);
            dgwProducts.Margin = new Padding(3, 2, 3, 2);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowHeadersWidth = 82;
            dgwProducts.Size = new Size(683, 432);
            dgwProducts.TabIndex = 0;
            // 
            // txtSearchproduct
            // 
            txtSearchproduct.Location = new Point(17, 513);
            txtSearchproduct.Margin = new Padding(3, 2, 3, 2);
            txtSearchproduct.Name = "txtSearchproduct";
            txtSearchproduct.PlaceholderText = "Search Product";
            txtSearchproduct.Size = new Size(155, 31);
            txtSearchproduct.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts" });
            comboBox1.Location = new Point(506, 515);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 33);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 515);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 3;
            label1.Text = "Filter:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.125F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(603, 558);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 4;
            label2.Text = "Clean Filters";
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(txtPrice);
            grpProduct.Controls.Add(btnUploadImage);
            grpProduct.Controls.Add(label7);
            grpProduct.Controls.Add(pcbImage);
            grpProduct.Controls.Add(label6);
            grpProduct.Controls.Add(txtDescription);
            grpProduct.Controls.Add(label5);
            grpProduct.Controls.Add(label4);
            grpProduct.Controls.Add(label3);
            grpProduct.Controls.Add(cmbCategory);
            grpProduct.Controls.Add(txtProductName);
            grpProduct.Location = new Point(736, 68);
            grpProduct.Margin = new Padding(3, 2, 3, 2);
            grpProduct.Name = "grpProduct";
            grpProduct.Padding = new Padding(3, 2, 3, 2);
            grpProduct.Size = new Size(439, 492);
            grpProduct.TabIndex = 5;
            grpProduct.TabStop = false;
            grpProduct.Text = "Product Details";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(179, 185);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(235, 31);
            txtPrice.TabIndex = 10;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(36, 428);
            btnUploadImage.Margin = new Padding(3, 2, 3, 2);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(116, 37);
            btnUploadImage.TabIndex = 9;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 370);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 8;
            label7.Text = "Upload Picture:";
            // 
            // pcbImage
            // 
            pcbImage.Location = new Point(179, 370);
            pcbImage.Margin = new Padding(3, 2, 3, 2);
            pcbImage.Name = "pcbImage";
            pcbImage.Size = new Size(179, 93);
            pcbImage.TabIndex = 7;
            pcbImage.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 258);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 6;
            label6.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(179, 248);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(235, 86);
            txtDescription.TabIndex = 6;
            txtDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 185);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 133);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 88);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts" });
            cmbCategory.Location = new Point(179, 130);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(235, 33);
            cmbCategory.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(179, 83);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Size = new Size(235, 31);
            txtProductName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(959, 576);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 67);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(753, 576);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(177, 67);
            button2.TabIndex = 7;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(753, 666);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(177, 65);
            button3.TabIndex = 8;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(959, 666);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(177, 65);
            button5.TabIndex = 9;
            button5.Text = "CLEAN";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(9, 11);
            btnMainMenu.Margin = new Padding(4, 5, 4, 5);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(44, 50);
            btnMainMenu.TabIndex = 10;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 775);
            Controls.Add(btnMainMenu);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(grpProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtSearchproduct);
            Controls.Add(dgwProducts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuForm";
            Text = "MenuScreen";
            Load += MenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwProducts;
        private TextBox txtSearchproduct;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private GroupBox grpProduct;
        private Label label3;
        private ComboBox cmbCategory;
        private TextBox txtProductName;
        private Label label6;
        private RichTextBox txtDescription;
        private Label label5;
        private Label label4;
        private Label label7;
        private PictureBox pcbImage;
        private Button btnAdd;
        private Button btnUploadImage;
        private Button button2;
        private Button button3;
        private Button button5;
        private TextBox txtPrice;
        private Button btnMainMenu;
    }
}