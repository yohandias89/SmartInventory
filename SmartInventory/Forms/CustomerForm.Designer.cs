namespace SmartInventory.Forms
{
    partial class CustomerForm
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
            lblCustomerCode = new Label();
            txtCustomerCode = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblDateOfBirth = new Label();
            txtDateOfBirth = new TextBox();
            lblNIC = new Label();
            txtNIC = new TextBox();
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
            errpCustomerForm = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errpCustomerForm).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerCode
            // 
            lblCustomerCode.AutoSize = true;
            lblCustomerCode.Location = new Point(13, 12);
            lblCustomerCode.Name = "lblCustomerCode";
            lblCustomerCode.Size = new Size(118, 20);
            lblCustomerCode.TabIndex = 0;
            lblCustomerCode.Text = "Customer Code :";
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.Location = new Point(128, 12);
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.ReadOnly = true;
            txtCustomerCode.Size = new Size(232, 27);
            txtCustomerCode.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(44, 45);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(128, 45);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(232, 27);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(45, 78);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 20);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(128, 78);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(232, 27);
            txtLastName.TabIndex = 5;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(30, 111);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(101, 20);
            lblDateOfBirth.TabIndex = 6;
            lblDateOfBirth.Text = "Date of Birth :";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(128, 111);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(232, 27);
            txtDateOfBirth.TabIndex = 7;
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Location = new Point(89, 144);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(40, 20);
            lblNIC.TabIndex = 8;
            lblNIC.Text = "NIC :";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(128, 144);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(232, 27);
            txtNIC.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(60, 177);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(128, 177);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(686, 27);
            txtAddress.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(76, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(686, 27);
            txtEmail.TabIndex = 13;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(62, 243);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(67, 20);
            lblContact.TabIndex = 14;
            lblContact.Text = "Contact :";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(128, 243);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(232, 27);
            txtContact.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(128, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 29);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(239, 289);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(350, 289);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 29);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(461, 289);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 29);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // errpCustomerForm
            // 
            errpCustomerForm.ContainerControl = this;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 331);
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
            Controls.Add(txtNIC);
            Controls.Add(lblNIC);
            Controls.Add(txtDateOfBirth);
            Controls.Add(lblDateOfBirth);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtCustomerCode);
            Controls.Add(lblCustomerCode);
            MaximizeBox = false;
            Name = "CustomerForm";
            Text = "Customer Form";
            ((System.ComponentModel.ISupportInitialize)errpCustomerForm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerCode;
        private TextBox txtCustomerCode;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblDateOfBirth;
        private TextBox txtDateOfBirth;
        private Label lblNIC;
        private TextBox txtNIC;
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
        private ErrorProvider errpCustomerForm;
    }
}