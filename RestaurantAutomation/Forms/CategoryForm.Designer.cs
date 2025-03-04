namespace RestaurantAutomation.UI.Forms
{
    partial class CategoryForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            txtAddName = new TextBox();
            lblName = new Label();
            lblDescription = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnList = new Button();
            txtAddDesc = new TextBox();
            grpboxAdd = new GroupBox();
            btnSaveNew = new Button();
            grpBoxDelete = new GroupBox();
            cmbDeleteCategory = new ComboBox();
            label5 = new Label();
            btnDeleteCategory = new Button();
            btnEditSave = new Button();
            label4 = new Label();
            label3 = new Label();
            txtEditName = new TextBox();
            txtEditDesc = new TextBox();
            grpBoxEdit = new GroupBox();
            cmbEditCategory = new ComboBox();
            label1 = new Label();
            btnAdd = new Button();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            grpboxAdd.SuspendLayout();
            grpBoxDelete.SuspendLayout();
            grpBoxEdit.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = categoryBindingSource;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(958, 262);
            dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Entities.Models.Category);
            // 
            // txtAddName
            // 
            txtAddName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddName.Location = new Point(215, 38);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(541, 27);
            txtAddName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Category Name:";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(26, 82);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(152, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Category Description:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 55);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 476);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 55);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(12, 537);
            btnList.Name = "btnList";
            btnList.Size = new Size(136, 55);
            btnList.TabIndex = 3;
            btnList.Text = "Refresh Categories";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // txtAddDesc
            // 
            txtAddDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddDesc.Location = new Point(215, 79);
            txtAddDesc.Multiline = true;
            txtAddDesc.Name = "txtAddDesc";
            txtAddDesc.ScrollBars = ScrollBars.Vertical;
            txtAddDesc.Size = new Size(463, 153);
            txtAddDesc.TabIndex = 1;
            // 
            // grpboxAdd
            // 
            grpboxAdd.Controls.Add(btnSaveNew);
            grpboxAdd.Controls.Add(txtAddDesc);
            grpboxAdd.Controls.Add(txtAddName);
            grpboxAdd.Controls.Add(lblName);
            grpboxAdd.Controls.Add(lblDescription);
            grpboxAdd.Location = new Point(169, 354);
            grpboxAdd.Name = "grpboxAdd";
            grpboxAdd.Size = new Size(801, 238);
            grpboxAdd.TabIndex = 4;
            grpboxAdd.TabStop = false;
            grpboxAdd.Text = "Add New Category";
            grpboxAdd.Visible = false;
            // 
            // btnSaveNew
            // 
            btnSaveNew.Location = new Point(684, 193);
            btnSaveNew.Name = "btnSaveNew";
            btnSaveNew.Size = new Size(111, 39);
            btnSaveNew.TabIndex = 6;
            btnSaveNew.Text = "Save";
            btnSaveNew.UseVisualStyleBackColor = true;
            btnSaveNew.Click += btnSaveNew_Click;
            // 
            // grpBoxDelete
            // 
            grpBoxDelete.Controls.Add(cmbDeleteCategory);
            grpBoxDelete.Controls.Add(label5);
            grpBoxDelete.Controls.Add(btnDeleteCategory);
            grpBoxDelete.Location = new Point(169, 354);
            grpBoxDelete.Name = "grpBoxDelete";
            grpBoxDelete.Size = new Size(801, 238);
            grpBoxDelete.TabIndex = 5;
            grpBoxDelete.TabStop = false;
            grpBoxDelete.Text = "Delete Category";
            // 
            // cmbDeleteCategory
            // 
            cmbDeleteCategory.DataBindings.Add(new Binding("SelectedItem", categoryBindingSource, "Name", true));
            cmbDeleteCategory.DataBindings.Add(new Binding("SelectedValue", categoryBindingSource, "ID", true));
            cmbDeleteCategory.FormattingEnabled = true;
            cmbDeleteCategory.Location = new Point(267, 82);
            cmbDeleteCategory.Name = "cmbDeleteCategory";
            cmbDeleteCategory.Size = new Size(463, 28);
            cmbDeleteCategory.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(78, 82);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 2;
            label5.Text = "Select Category:";
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(420, 128);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(128, 39);
            btnDeleteCategory.TabIndex = 3;
            btnDeleteCategory.Text = "Delete Category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditSave
            // 
            btnEditSave.Location = new Point(684, 189);
            btnEditSave.Name = "btnEditSave";
            btnEditSave.Size = new Size(111, 39);
            btnEditSave.TabIndex = 3;
            btnEditSave.Text = "Save";
            btnEditSave.UseVisualStyleBackColor = true;
            btnEditSave.Click += btnEditSave_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(26, 124);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 2;
            label4.Text = "Category Description:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(26, 87);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Category Name:";
            // 
            // txtEditName
            // 
            txtEditName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEditName.Location = new Point(215, 80);
            txtEditName.Name = "txtEditName";
            txtEditName.Size = new Size(463, 27);
            txtEditName.TabIndex = 1;
            // 
            // txtEditDesc
            // 
            txtEditDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEditDesc.Location = new Point(215, 121);
            txtEditDesc.Multiline = true;
            txtEditDesc.Name = "txtEditDesc";
            txtEditDesc.ScrollBars = ScrollBars.Vertical;
            txtEditDesc.Size = new Size(463, 107);
            txtEditDesc.TabIndex = 1;
            // 
            // grpBoxEdit
            // 
            grpBoxEdit.Controls.Add(cmbEditCategory);
            grpBoxEdit.Controls.Add(label1);
            grpBoxEdit.Controls.Add(txtEditDesc);
            grpBoxEdit.Controls.Add(txtEditName);
            grpBoxEdit.Controls.Add(label3);
            grpBoxEdit.Controls.Add(label4);
            grpBoxEdit.Controls.Add(btnEditSave);
            grpBoxEdit.Location = new Point(169, 354);
            grpBoxEdit.Name = "grpBoxEdit";
            grpBoxEdit.Size = new Size(801, 238);
            grpBoxEdit.TabIndex = 5;
            grpBoxEdit.TabStop = false;
            grpBoxEdit.Text = "Edit Category";
            grpBoxEdit.Visible = false;
            // 
            // cmbEditCategory
            // 
            cmbEditCategory.DataBindings.Add(new Binding("SelectedItem", categoryBindingSource, "Name", true));
            cmbEditCategory.DataBindings.Add(new Binding("SelectedValue", categoryBindingSource, "ID", true));
            cmbEditCategory.FormattingEnabled = true;
            cmbEditCategory.Items.AddRange(new object[] { "" });
            cmbEditCategory.Location = new Point(215, 46);
            cmbEditCategory.Name = "cmbEditCategory";
            cmbEditCategory.Size = new Size(463, 28);
            cmbEditCategory.TabIndex = 5;
            cmbEditCategory.SelectedIndexChanged += cmbEditCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(26, 46);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 4;
            label1.Text = "Select Category:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 55);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.Location = new Point(12, 8);
            btnMainMenu.Margin = new Padding(3, 4, 3, 4);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(35, 40);
            btnMainMenu.TabIndex = 11;
            btnMainMenu.Text = "🡰";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 610);
            ControlBox = false;
            Controls.Add(btnMainMenu);
            Controls.Add(btnAdd);
            Controls.Add(grpBoxEdit);
            Controls.Add(grpBoxDelete);
            Controls.Add(grpboxAdd);
            Controls.Add(btnList);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Categories";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            grpboxAdd.ResumeLayout(false);
            grpboxAdd.PerformLayout();
            grpBoxDelete.ResumeLayout(false);
            grpBoxDelete.PerformLayout();
            grpBoxEdit.ResumeLayout(false);
            grpBoxEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private TextBox txtAddName;
        private Label lblName;
        private Label lblDescription;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnList;
        private TextBox txtAddDesc;
        private GroupBox grpboxAdd;
        private GroupBox grpBoxDelete;
        private ComboBox cmbDeleteCategory;
        private Label label5;
        private Button btnDeleteCategory;
        private Button btnEditSave;
        private Label label4;
        private Label label3;
        private TextBox txtEditName;
        private TextBox txtEditDesc;
        private GroupBox grpBoxEdit;
        private ComboBox cmbEditCategory;
        private Label label1;
        private Button btnSaveNew;
        private Button btnAdd;
        private Button btnMainMenu;
    }
}