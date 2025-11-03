namespace SmartInventory.Forms
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
            lblCategoryCode = new Label();
            txtCategoryCode = new TextBox();
            lblCategoryName = new Label();
            txtCategoryName = new TextBox();
            lblPadding = new Label();
            txtPadding = new TextBox();
            lblNextNo = new Label();
            txtNextNo = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCategories = new DataGridView();
            errpCategory = new ErrorProvider(components);
            btnPrevious = new Button();
            btnNext = new Button();
            txtPageInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errpCategory).BeginInit();
            SuspendLayout();
            // 
            // lblCategoryCode
            // 
            lblCategoryCode.AutoSize = true;
            lblCategoryCode.Location = new Point(37, 33);
            lblCategoryCode.Name = "lblCategoryCode";
            lblCategoryCode.Size = new Size(115, 20);
            lblCategoryCode.TabIndex = 1;
            lblCategoryCode.Text = "Ctaegory Code :";
            // 
            // txtCategoryCode
            // 
            txtCategoryCode.Location = new Point(158, 30);
            txtCategoryCode.Name = "txtCategoryCode";
            txtCategoryCode.Size = new Size(215, 27);
            txtCategoryCode.TabIndex = 2;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(32, 66);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(120, 20);
            lblCategoryName.TabIndex = 3;
            lblCategoryName.Text = "Category Name :";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(159, 69);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(549, 27);
            txtCategoryName.TabIndex = 4;
            // 
            // lblPadding
            // 
            lblPadding.AutoSize = true;
            lblPadding.Location = new Point(82, 106);
            lblPadding.Name = "lblPadding";
            lblPadding.Size = new Size(70, 20);
            lblPadding.TabIndex = 5;
            lblPadding.Text = "Padding :";
            // 
            // txtPadding
            // 
            txtPadding.Location = new Point(160, 106);
            txtPadding.Name = "txtPadding";
            txtPadding.Size = new Size(213, 27);
            txtPadding.TabIndex = 6;
            // 
            // lblNextNo
            // 
            lblNextNo.AutoSize = true;
            lblNextNo.Location = new Point(81, 144);
            lblNextNo.Name = "lblNextNo";
            lblNextNo.Size = new Size(71, 20);
            lblNextNo.TabIndex = 7;
            lblNextNo.Text = "Next No :";
            // 
            // txtNextNo
            // 
            txtNextNo.Location = new Point(160, 142);
            txtNextNo.Name = "txtNextNo";
            txtNextNo.Size = new Size(213, 27);
            txtNextNo.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(159, 189);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(264, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(364, 189);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(464, 189);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(-4, 224);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(1229, 377);
            dgvCategories.TabIndex = 17;
            // 
            // errpCategory
            // 
            errpCategory.ContainerControl = this;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(395, 607);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 18;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += BtnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(495, 607);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 19;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // txtPageInfo
            // 
            txtPageInfo.Location = new Point(595, 607);
            txtPageInfo.Name = "txtPageInfo";
            txtPageInfo.Size = new Size(125, 27);
            txtPageInfo.TabIndex = 20;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 648);
            Controls.Add(txtPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dgvCategories);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtNextNo);
            Controls.Add(lblNextNo);
            Controls.Add(txtPadding);
            Controls.Add(lblPadding);
            Controls.Add(txtCategoryName);
            Controls.Add(lblCategoryName);
            Controls.Add(txtCategoryCode);
            Controls.Add(lblCategoryCode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CategoryForm";
            Text = "Category";
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)errpCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCategoryCode;
        private TextBox txtCategoryCode;
        private Label lblCategoryName;
        private TextBox txtCategoryName;
        private Label lblPadding;
        private TextBox txtPadding;
        private Label lblNextNo;
        private TextBox txtNextNo;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvCategories;
        private ErrorProvider errpCategory;
        private TextBox txtPageInfo;
        private Button btnNext;
        private Button btnPrevious;
    }
}