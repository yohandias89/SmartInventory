namespace SmartInventory.Forms.CustomerForms
{
    partial class CustomerList
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
            dgvCustomers = new DataGridView();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblNIC = new Label();
            txtNIC = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            btnSearch = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            txtPageInfo = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(-2, 65);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(1798, 457);
            dgvCustomers.TabIndex = 0;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(197, 9);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 20);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(197, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(180, 27);
            txtFirstName.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(383, 9);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 20);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(383, 32);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(180, 27);
            txtLastName.TabIndex = 6;
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Location = new Point(569, 9);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(40, 20);
            lblNIC.TabIndex = 7;
            lblNIC.Text = "NIC :";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(569, 32);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(209, 27);
            txtNIC.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(784, 9);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(784, 32);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 27);
            txtEmail.TabIndex = 10;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(1150, 9);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(67, 20);
            lblContact.TabIndex = 11;
            lblContact.Text = "Contact :";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(1150, 32);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(209, 27);
            txtContact.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1365, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(578, 528);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 14;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += BtnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(678, 528);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 15;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // txtPageInfo
            // 
            txtPageInfo.Location = new Point(778, 530);
            txtPageInfo.Name = "txtPageInfo";
            txtPageInfo.ReadOnly = true;
            txtPageInfo.Size = new Size(125, 27);
            txtPageInfo.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1465, 28);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1797, 566);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnSearch);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNIC);
            Controls.Add(lblNIC);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(dgvCustomers);
            Name = "CustomerList";
            Text = "CustomerList";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblNIC;
        private TextBox txtNIC;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblContact;
        private TextBox txtContact;
        private Button btnSearch;
        private Button btnPrevious;
        private Button btnNext;
        private TextBox txtPageInfo;
        private Button btnAdd;
        private Button btnClear;
    }
}