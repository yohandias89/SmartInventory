namespace SmartInventory.Forms
{
    partial class SupplierForm
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
            lblSupplierCode = new Label();
            txtSupplierCode = new TextBox();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblContactPerson = new Label();
            txtContactPerson = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvSuppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // lblSupplierCode
            // 
            lblSupplierCode.AutoSize = true;
            lblSupplierCode.Location = new Point(33, 9);
            lblSupplierCode.Name = "lblSupplierCode";
            lblSupplierCode.Size = new Size(110, 20);
            lblSupplierCode.TabIndex = 0;
            lblSupplierCode.Text = "Supplier Code :";
            // 
            // txtSupplierCode
            // 
            txtSupplierCode.Location = new Point(149, 9);
            txtSupplierCode.Name = "txtSupplierCode";
            txtSupplierCode.Size = new Size(227, 27);
            txtSupplierCode.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(28, 47);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(115, 20);
            lblSupplierName.TabIndex = 2;
            lblSupplierName.Text = "Supplier Name :";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(149, 44);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(486, 27);
            txtSupplierName.TabIndex = 3;
            // 
            // lblContactPerson
            // 
            lblContactPerson.AutoSize = true;
            lblContactPerson.Location = new Point(28, 81);
            lblContactPerson.Name = "lblContactPerson";
            lblContactPerson.Size = new Size(109, 20);
            lblContactPerson.TabIndex = 4;
            lblContactPerson.Text = "Conact Person :";
            // 
            // txtContactPerson
            // 
            txtContactPerson.Location = new Point(148, 85);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(487, 27);
            txtContactPerson.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(34, 127);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(149, 124);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(626, 27);
            txtAddress.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(37, 172);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(628, 27);
            txtEmail.TabIndex = 9;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(50, 216);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(67, 20);
            lblContact.TabIndex = 10;
            lblContact.Text = "Contact :";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(146, 213);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(146, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(246, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(347, 248);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(447, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(28, 330);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(747, 345);
            dgvSuppliers.TabIndex = 16;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 703);
            Controls.Add(dgvSuppliers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContactPerson);
            Controls.Add(lblContactPerson);
            Controls.Add(txtSupplierName);
            Controls.Add(lblSupplierName);
            Controls.Add(txtSupplierCode);
            Controls.Add(lblSupplierCode);
            Name = "SupplierForm";
            Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSupplierCode;
        private TextBox txtSupplierCode;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblContactPerson;
        private TextBox txtContactPerson;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblContact;
        private TextBox txtContact;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvSuppliers;
    }
}