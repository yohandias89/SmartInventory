namespace SmartInventory.Forms
{
    partial class ProductForm
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
            lblSubCategoryCode = new Label();
            cmbSubCategoryCode = new ComboBox();
            lblProductCode = new Label();
            txtProductCode = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblNextNo = new Label();
            txtNextNo = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblCategoryCode
            // 
            lblCategoryCode.AutoSize = true;
            lblCategoryCode.Location = new Point(41, 12);
            lblCategoryCode.Name = "lblCategoryCode";
            lblCategoryCode.Size = new Size(115, 20);
            lblCategoryCode.TabIndex = 0;
            lblCategoryCode.Text = "Category Code :";
            // 
            // cmbCategoryCode
            // 
            cmbCategoryCode.FormattingEnabled = true;
            cmbCategoryCode.Location = new Point(163, 12);
            cmbCategoryCode.Name = "cmbCategoryCode";
            cmbCategoryCode.Size = new Size(268, 28);
            cmbCategoryCode.TabIndex = 1;
            // 
            // lblSubCategoryCode
            // 
            lblSubCategoryCode.AutoSize = true;
            lblSubCategoryCode.Location = new Point(12, 55);
            lblSubCategoryCode.Name = "lblSubCategoryCode";
            lblSubCategoryCode.Size = new Size(144, 20);
            lblSubCategoryCode.TabIndex = 2;
            lblSubCategoryCode.Text = "Sub Category Code :";
            // 
            // cmbSubCategoryCode
            // 
            cmbSubCategoryCode.FormattingEnabled = true;
            cmbSubCategoryCode.Location = new Point(163, 46);
            cmbSubCategoryCode.Name = "cmbSubCategoryCode";
            cmbSubCategoryCode.Size = new Size(268, 28);
            cmbSubCategoryCode.TabIndex = 3;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(50, 80);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(106, 20);
            lblProductCode.TabIndex = 4;
            lblProductCode.Text = "Product Code :";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(163, 80);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.ReadOnly = true;
            txtProductCode.Size = new Size(268, 27);
            txtProductCode.TabIndex = 5;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(41, 113);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(111, 20);
            lblProductName.TabIndex = 6;
            lblProductName.Text = "Product Name :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(163, 113);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(570, 27);
            txtProductName.TabIndex = 7;
            // 
            // lblNextNo
            // 
            lblNextNo.AutoSize = true;
            lblNextNo.Location = new Point(81, 147);
            lblNextNo.Name = "lblNextNo";
            lblNextNo.Size = new Size(71, 20);
            lblNextNo.TabIndex = 8;
            lblNextNo.Text = "Next No :";
            // 
            // txtNextNo
            // 
            txtNextNo.Location = new Point(163, 147);
            txtNextNo.Name = "txtNextNo";
            txtNextNo.Size = new Size(125, 27);
            txtNextNo.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(163, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(263, 195);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 236);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtNextNo);
            Controls.Add(lblNextNo);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(txtProductCode);
            Controls.Add(lblProductCode);
            Controls.Add(cmbSubCategoryCode);
            Controls.Add(lblSubCategoryCode);
            Controls.Add(cmbCategoryCode);
            Controls.Add(lblCategoryCode);
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryCode;
        private ComboBox cmbCategoryCode;
        private Label lblSubCategoryCode;
        private ComboBox cmbSubCategoryCode;
        private Label lblProductCode;
        private TextBox txtProductCode;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblNextNo;
        private TextBox txtNextNo;
        private Button btnSave;
        private Button btnClear;
    }
}