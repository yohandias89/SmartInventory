namespace SmartInventory.Forms
{
    partial class SubcategoryForm
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
            lblCategoryCode = new Label();
            cmbCategoryCode = new ComboBox();
            label1 = new Label();
            txtSubCategoryCode = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            dgvSubCategories = new DataGridView();
            label2 = new Label();
            txtSubCategoryName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSubCategories).BeginInit();
            SuspendLayout();
            // 
            // lblCategoryCode
            // 
            lblCategoryCode.AutoSize = true;
            lblCategoryCode.Location = new Point(51, 15);
            lblCategoryCode.Name = "lblCategoryCode";
            lblCategoryCode.Size = new Size(115, 20);
            lblCategoryCode.TabIndex = 0;
            lblCategoryCode.Text = "Category Code :";
            // 
            // cmbCategoryCode
            // 
            cmbCategoryCode.FormattingEnabled = true;
            cmbCategoryCode.Location = new Point(172, 12);
            cmbCategoryCode.Name = "cmbCategoryCode";
            cmbCategoryCode.Size = new Size(310, 28);
            cmbCategoryCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 52);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 2;
            label1.Text = "Sub Category Code :";
            // 
            // txtSubCategoryCode
            // 
            txtSubCategoryCode.Location = new Point(172, 52);
            txtSubCategoryCode.Name = "txtSubCategoryCode";
            txtSubCategoryCode.Size = new Size(310, 27);
            txtSubCategoryCode.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(171, 142);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(271, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(371, 142);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(471, 142);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // dgvSubCategories
            // 
            dgvSubCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubCategories.Location = new Point(22, 203);
            dgvSubCategories.Name = "dgvSubCategories";
            dgvSubCategories.RowHeadersWidth = 51;
            dgvSubCategories.Size = new Size(1357, 290);
            dgvSubCategories.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 96);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 9;
            label2.Text = "Sub Category Name :";
            // 
            // txtSubCategoryName
            // 
            txtSubCategoryName.Location = new Point(172, 96);
            txtSubCategoryName.Name = "txtSubCategoryName";
            txtSubCategoryName.Size = new Size(552, 27);
            txtSubCategoryName.TabIndex = 10;
            // 
            // SubcategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 574);
            Controls.Add(txtSubCategoryName);
            Controls.Add(label2);
            Controls.Add(dgvSubCategories);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtSubCategoryCode);
            Controls.Add(label1);
            Controls.Add(cmbCategoryCode);
            Controls.Add(lblCategoryCode);
            Name = "SubcategoryForm";
            Text = "SubcategoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvSubCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryCode;
        private ComboBox cmbCategoryCode;
        private Label label1;
        private TextBox txtSubCategoryCode;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private DataGridView dgvSubCategories;
        private Label label2;
        private TextBox txtSubCategoryName;
    }
}