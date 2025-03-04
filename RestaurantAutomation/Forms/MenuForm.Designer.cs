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
            txtSearchText = new TextBox();
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
            btnDel = new Button();
            btnClear = new Button();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbImage).BeginInit();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(7, 137);
            dgwProducts.Margin = new Padding(2, 1, 2, 1);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowHeadersWidth = 82;
            dgwProducts.Size = new Size(546, 372);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // txtSearchText
            // 
            txtSearchText.Location = new Point(7, 81);
            txtSearchText.Margin = new Padding(2, 1, 2, 1);
            txtSearchText.Name = "txtSearchText";
            txtSearchText.PlaceholderText = "Search";
            txtSearchText.Size = new Size(218, 27);
            txtSearchText.TabIndex = 1;
            txtSearchText.TextChanged += txtSearchText_TextChanged;
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
            grpProduct.Location = new Point(589, 55);
            grpProduct.Margin = new Padding(2, 1, 2, 1);
            grpProduct.Name = "grpProduct";
            grpProduct.Padding = new Padding(2, 1, 2, 1);
            grpProduct.Size = new Size(419, 393);
            grpProduct.TabIndex = 5;
            grpProduct.TabStop = false;
            grpProduct.Text = "Product Details";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(145, 108);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(229, 27);
            txtPrice.TabIndex = 10;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(16, 337);
            btnUploadImage.Margin = new Padding(2, 1, 2, 1);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(106, 40);
            btnUploadImage.TabIndex = 9;
            btnUploadImage.Text = "Upload";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 256);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 8;
            label7.Text = "Upload Picture:";
            // 
            // pcbImage
            // 
            pcbImage.BackColor = Color.LightGray;
            pcbImage.Location = new Point(145, 256);
            pcbImage.Margin = new Padding(2, 1, 2, 1);
            pcbImage.Name = "pcbImage";
            pcbImage.Size = new Size(230, 121);
            pcbImage.TabIndex = 7;
            pcbImage.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 159);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 6;
            label6.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(145, 159);
            txtDescription.Margin = new Padding(2, 1, 2, 1);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 69);
            txtDescription.TabIndex = 6;
            txtDescription.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 112);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 68);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 31);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts" });
            cmbCategory.Location = new Point(145, 64);
            cmbCategory.Margin = new Padding(2, 1, 2, 1);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(229, 28);
            cmbCategory.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(145, 27);
            txtProductName.Margin = new Padding(2, 1, 2, 1);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(229, 27);
            txtProductName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(602, 457);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 53);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "SAVE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(754, 457);
            btnDel.Margin = new Padding(2, 1, 2, 1);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(113, 52);
            btnDel.TabIndex = 8;
            btnDel.Text = "DELETE";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(895, 459);
            btnClear.Margin = new Padding(2, 1, 2, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 52);
            btnClear.TabIndex = 9;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(7, 9);
            btnMainMenu.Margin = new Padding(3, 4, 3, 4);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(35, 40);
            btnMainMenu.TabIndex = 10;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 851);
            ControlBox = false;
            Controls.Add(btnMainMenu);
            Controls.Add(btnClear);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(grpProduct);
            Controls.Add(txtSearchText);
            Controls.Add(dgwProducts);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restaurant Menu Management";
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
        private TextBox txtSearchText;
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
        private Button btnDel;
        private Button btnClear;
        private TextBox txtPrice;
        private Button btnMainMenu;
    }
}