namespace RestaurantAutomation.UI.Forms
{
    partial class MenuScreen
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
            dataGridViewMenu = new DataGridView();
            txtSearchproduct = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            grpProduct = new GroupBox();
            button4 = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            richTextBox1 = new RichTextBox();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).BeginInit();
            grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            dataGridViewMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMenu.Columns.AddRange(new DataGridViewColumn[] { colName, colCategory, colPrice });
            dataGridViewMenu.Location = new Point(11, 45);
            dataGridViewMenu.Name = "dataGridViewMenu";
            dataGridViewMenu.RowHeadersWidth = 82;
            dataGridViewMenu.Size = new Size(887, 552);
            dataGridViewMenu.TabIndex = 0;
            dataGridViewMenu.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearchproduct
            // 
            txtSearchproduct.Location = new Point(23, 614);
            txtSearchproduct.Name = "txtSearchproduct";
            txtSearchproduct.PlaceholderText = "Search Product";
            txtSearchproduct.Size = new Size(201, 39);
            txtSearchproduct.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts" });
            comboBox1.Location = new Point(657, 617);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 40);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 617);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 3;
            label1.Text = "Filter:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.125F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.Location = new Point(783, 672);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 4;
            label2.Text = "Clean Filters";
            label2.Click += label2_Click;
            // 
            // grpProduct
            // 
            grpProduct.Controls.Add(button4);
            grpProduct.Controls.Add(label7);
            grpProduct.Controls.Add(pictureBox1);
            grpProduct.Controls.Add(label6);
            grpProduct.Controls.Add(richTextBox1);
            grpProduct.Controls.Add(numericUpDown1);
            grpProduct.Controls.Add(label5);
            grpProduct.Controls.Add(label4);
            grpProduct.Controls.Add(label3);
            grpProduct.Controls.Add(comboBox2);
            grpProduct.Controls.Add(textBox1);
            grpProduct.Location = new Point(956, 45);
            grpProduct.Name = "grpProduct";
            grpProduct.Size = new Size(570, 629);
            grpProduct.TabIndex = 5;
            grpProduct.TabStop = false;
            grpProduct.Text = "Product Details";
            // 
            // button4
            // 
            button4.Location = new Point(47, 506);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 9;
            button4.Text = "Upload";
            button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 432);
            label7.Name = "label7";
            label7.Size = new Size(175, 32);
            label7.TabIndex = 8;
            label7.Text = "Upload Picture:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(233, 432);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 120);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 287);
            label6.Name = "label6";
            label6.Size = new Size(140, 32);
            label6.TabIndex = 6;
            label6.Text = "Description:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(233, 275);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(304, 109);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(226, 194);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 194);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 127);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 3;
            label4.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 70);
            label3.Name = "label3";
            label3.Size = new Size(172, 32);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Main Courses", "Starters", "Beverages", "Desserts" });
            comboBox2.Location = new Point(233, 124);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(304, 40);
            comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 63);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Product Name";
            textBox1.Size = new Size(304, 39);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1246, 696);
            button1.Name = "button1";
            button1.Size = new Size(231, 86);
            button1.TabIndex = 6;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(978, 696);
            button2.Name = "button2";
            button2.Size = new Size(231, 86);
            button2.TabIndex = 7;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(978, 810);
            button3.Name = "button3";
            button3.Size = new Size(231, 84);
            button3.TabIndex = 8;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1246, 810);
            button5.Name = "button5";
            button5.Size = new Size(231, 84);
            button5.TabIndex = 9;
            button5.Text = "CLEAN";
            button5.UseVisualStyleBackColor = true;
            // 
            // colName
            // 
            colName.HeaderText = "Product Name";
            colName.MinimumWidth = 10;
            colName.Name = "colName";
            colName.Resizable = DataGridViewTriState.True;
            colName.Width = 400;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 10;
            colCategory.Name = "colCategory";
            colCategory.Resizable = DataGridViewTriState.True;
            colCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            colCategory.Width = 200;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 10;
            colPrice.Name = "colPrice";
            colPrice.Width = 200;
            // 
            // MenuScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 992);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grpProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtSearchproduct);
            Controls.Add(dataGridViewMenu);
            Name = "MenuScreen";
            Text = "MenuScreen";
            Load += MenuScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMenu).EndInit();
            grpProduct.ResumeLayout(false);
            grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMenu;
        private TextBox txtSearchproduct;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private GroupBox grpProduct;
        private Label label3;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label6;
        private RichTextBox richTextBox1;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label4;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button5;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
    }
}