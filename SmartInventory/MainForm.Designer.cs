namespace SmartInventory
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            subCategoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            productListToolStripMenuItem = new ToolStripMenuItem();
            productBatchToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            unitOfMesurementToolStripMenuItem = new ToolStripMenuItem();
            serialNumbersToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            purchaseToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            systemUsersToolStripMenuItem = new ToolStripMenuItem();
            userRoleToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutSoftwareToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, transactionToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1375, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, subCategoryToolStripMenuItem, productToolStripMenuItem, employeeToolStripMenuItem, supplierToolStripMenuItem, customerToolStripMenuItem, unitOfMesurementToolStripMenuItem, serialNumbersToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(224, 26);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += CategoryToolStripMenuItem_Click;
            // 
            // subCategoryToolStripMenuItem
            // 
            subCategoryToolStripMenuItem.Name = "subCategoryToolStripMenuItem";
            subCategoryToolStripMenuItem.Size = new Size(224, 26);
            subCategoryToolStripMenuItem.Text = "Sub Category";
            subCategoryToolStripMenuItem.Click += SubCategoryToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productListToolStripMenuItem, productBatchToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(224, 26);
            productToolStripMenuItem.Text = "Product";
            // 
            // productListToolStripMenuItem
            // 
            productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            productListToolStripMenuItem.Size = new Size(184, 26);
            productListToolStripMenuItem.Text = "Product List";
            // 
            // productBatchToolStripMenuItem
            // 
            productBatchToolStripMenuItem.Name = "productBatchToolStripMenuItem";
            productBatchToolStripMenuItem.Size = new Size(184, 26);
            productBatchToolStripMenuItem.Text = "Product Batch";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(224, 26);
            employeeToolStripMenuItem.Text = "Employee";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(224, 26);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(224, 26);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // unitOfMesurementToolStripMenuItem
            // 
            unitOfMesurementToolStripMenuItem.Name = "unitOfMesurementToolStripMenuItem";
            unitOfMesurementToolStripMenuItem.Size = new Size(224, 26);
            unitOfMesurementToolStripMenuItem.Text = "Unit of Mesurement";
            // 
            // serialNumbersToolStripMenuItem
            // 
            serialNumbersToolStripMenuItem.Name = "serialNumbersToolStripMenuItem";
            serialNumbersToolStripMenuItem.Size = new Size(224, 26);
            serialNumbersToolStripMenuItem.Text = "Serial Numbers";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { purchaseToolStripMenuItem, salesToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(98, 24);
            viewToolStripMenuItem.Text = "Transaction";
            // 
            // purchaseToolStripMenuItem
            // 
            purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            purchaseToolStripMenuItem.Size = new Size(150, 26);
            purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(150, 26);
            salesToolStripMenuItem.Text = "Sales";
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { systemUsersToolStripMenuItem, userRoleToolStripMenuItem });
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(75, 24);
            transactionToolStripMenuItem.Text = "Security";
            // 
            // systemUsersToolStripMenuItem
            // 
            systemUsersToolStripMenuItem.Name = "systemUsersToolStripMenuItem";
            systemUsersToolStripMenuItem.Size = new Size(178, 26);
            systemUsersToolStripMenuItem.Text = "System Users";
            // 
            // userRoleToolStripMenuItem
            // 
            userRoleToolStripMenuItem.Name = "userRoleToolStripMenuItem";
            userRoleToolStripMenuItem.Size = new Size(178, 26);
            userRoleToolStripMenuItem.Text = "User Role";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutSoftwareToolStripMenuItem, helpToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutSoftwareToolStripMenuItem
            // 
            aboutSoftwareToolStripMenuItem.Name = "aboutSoftwareToolStripMenuItem";
            aboutSoftwareToolStripMenuItem.Size = new Size(196, 26);
            aboutSoftwareToolStripMenuItem.Text = "About Software";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(196, 26);
            helpToolStripMenuItem.Text = "Help";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 585);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem subCategoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem productListToolStripMenuItem;
        private ToolStripMenuItem productBatchToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem unitOfMesurementToolStripMenuItem;
        private ToolStripMenuItem serialNumbersToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem systemUsersToolStripMenuItem;
        private ToolStripMenuItem userRoleToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutSoftwareToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}