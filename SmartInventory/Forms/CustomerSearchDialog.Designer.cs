namespace SmartInventory.Forms
{
    partial class CustomerSearchDialog
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
            dgvSearchedCustomers = new DataGridView();
            btnPrevious = new Button();
            btnNext = new Button();
            txtPageInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSearchedCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 9);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(203, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(221, 9);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(221, 32);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(192, 27);
            txtLastName.TabIndex = 3;
            // 
            // lblNIC
            // 
            lblNIC.AutoSize = true;
            lblNIC.Location = new Point(422, 9);
            lblNIC.Name = "lblNIC";
            lblNIC.Size = new Size(33, 20);
            lblNIC.TabIndex = 4;
            lblNIC.Text = "NIC";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(419, 32);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(206, 27);
            txtNIC.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(613, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(631, 9);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(60, 20);
            lblContact.TabIndex = 8;
            lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(631, 32);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(249, 27);
            txtContact.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(631, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSearchedCustomers
            // 
            dgvSearchedCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchedCustomers.Location = new Point(5, 121);
            dgvSearchedCustomers.Name = "dgvSearchedCustomers";
            dgvSearchedCustomers.RowHeadersWidth = 51;
            dgvSearchedCustomers.Size = new Size(1073, 273);
            dgvSearchedCustomers.TabIndex = 11;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(380, 440);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 12;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(480, 440);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 13;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtPageInfo
            // 
            txtPageInfo.Location = new Point(594, 440);
            txtPageInfo.Name = "txtPageInfo";
            txtPageInfo.ReadOnly = true;
            txtPageInfo.Size = new Size(125, 27);
            txtPageInfo.TabIndex = 14;
            // 
            // CustomerSearchDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 516);
            Controls.Add(txtPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(dgvSearchedCustomers);
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
            Name = "CustomerSearchDialog";
            Text = "CustomerSearchDialog";
            ((System.ComponentModel.ISupportInitialize)dgvSearchedCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DataGridView dgvSearchedCustomers;
        private Button btnPrevious;
        private Button btnNext;
        private TextBox txtPageInfo;
    }
}