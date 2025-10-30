namespace SmartInventory
{
    partial class LoginForm
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
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassowrd = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            lblTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(104, 115);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(89, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(201, 115);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(228, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(104, 155);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password :";
            // 
            // txtPassowrd
            // 
            txtPassowrd.Location = new Point(201, 148);
            txtPassowrd.Name = "txtPassowrd";
            txtPassowrd.Size = new Size(228, 27);
            txtPassowrd.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(201, 197);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(335, 197);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(116, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(333, 54);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Smart Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 269);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 7;
            label1.Text = "Software By Yohan Dias";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 311);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassowrd);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassowrd;
        private Button btnLogin;
        private Button btnExit;
        private Label lblTitle;
        private Label label1;
    }
}