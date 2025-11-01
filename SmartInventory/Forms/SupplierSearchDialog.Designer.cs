namespace SmartInventory.Forms
{
    partial class SupplierSearchDialog
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
            dgvSearchedSuppliers = new DataGridView();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            btnSearch = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            txtPageInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSearchedSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSearchedSuppliers
            // 
            dgvSearchedSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchedSuppliers.Location = new Point(-2, 76);
            dgvSearchedSuppliers.Name = "dgvSearchedSuppliers";
            dgvSearchedSuppliers.RowHeadersWidth = 51;
            dgvSearchedSuppliers.Size = new Size(1263, 386);
            dgvSearchedSuppliers.TabIndex = 0;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(17, 8);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(115, 20);
            lblSupplierName.TabIndex = 1;
            lblSupplierName.Text = "Supplier Name :";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(17, 31);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(314, 27);
            txtSupplierName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(336, 10);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(337, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(621, 12);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(67, 20);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact :";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(621, 31);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(282, 27);
            txtContact.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(909, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(451, 468);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 8;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(559, 469);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 9;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtPageInfo
            // 
            txtPageInfo.Location = new Point(664, 474);
            txtPageInfo.Name = "txtPageInfo";
            txtPageInfo.ReadOnly = true;
            txtPageInfo.Size = new Size(125, 27);
            txtPageInfo.TabIndex = 10;
            // 
            // SupplierSearchDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 505);
            Controls.Add(txtPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnSearch);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSupplierName);
            Controls.Add(lblSupplierName);
            Controls.Add(dgvSearchedSuppliers);
            Name = "SupplierSearchDialog";
            Text = "SupplierSearchDialog";
            ((System.ComponentModel.ISupportInitialize)dgvSearchedSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSearchedSuppliers;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblContact;
        private TextBox txtContact;
        private Button btnSearch;
        private Button btnPrevious;
        private Button btnNext;
        private TextBox txtPageInfo;
    }
}