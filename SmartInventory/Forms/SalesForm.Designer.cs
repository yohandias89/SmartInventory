namespace SmartInventory.Forms
{
    partial class SalesForm
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
            lblSalesCode = new Label();
            txtSalesCode = new TextBox();
            btnSalesSearch = new Button();
            lblCustomerCode = new Label();
            txtCustomerCode = new TextBox();
            btnCustomerSearch = new Button();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            lblProductCode = new Label();
            txtProductCode = new TextBox();
            btnSearchProduct = new Button();
            lblBatchCode = new Label();
            txtBatchCode = new TextBox();
            lblUnitCode = new Label();
            txtUnitCode = new TextBox();
            lblSellingPrice = new Label();
            txtSellingPrice = new TextBox();
            lblPurchaseQty = new Label();
            txtPurchaseQty = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            dataGridView1 = new DataGridView();
            lblTotalSales = new Label();
            txtTotalPurchase = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblSalesCode
            // 
            lblSalesCode.AutoSize = true;
            lblSalesCode.Location = new Point(40, 12);
            lblSalesCode.Name = "lblSalesCode";
            lblSalesCode.Size = new Size(89, 20);
            lblSalesCode.TabIndex = 0;
            lblSalesCode.Text = "Sales Code :";
            // 
            // txtSalesCode
            // 
            txtSalesCode.Location = new Point(135, 12);
            txtSalesCode.Name = "txtSalesCode";
            txtSalesCode.ReadOnly = true;
            txtSalesCode.Size = new Size(219, 27);
            txtSalesCode.TabIndex = 1;
            // 
            // btnSalesSearch
            // 
            btnSalesSearch.Location = new Point(360, 12);
            btnSalesSearch.Name = "btnSalesSearch";
            btnSalesSearch.Size = new Size(94, 29);
            btnSalesSearch.TabIndex = 2;
            btnSalesSearch.Text = "Search";
            btnSalesSearch.UseVisualStyleBackColor = true;
            btnSalesSearch.Click += btnSalesSearch_Click;
            // 
            // lblCustomerCode
            // 
            lblCustomerCode.AutoSize = true;
            lblCustomerCode.Location = new Point(11, 49);
            lblCustomerCode.Name = "lblCustomerCode";
            lblCustomerCode.Size = new Size(118, 20);
            lblCustomerCode.TabIndex = 3;
            lblCustomerCode.Text = "Customer Code :";
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.Location = new Point(135, 49);
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.ReadOnly = true;
            txtCustomerCode.Size = new Size(219, 27);
            txtCustomerCode.TabIndex = 4;
            // 
            // btnCustomerSearch
            // 
            btnCustomerSearch.Location = new Point(360, 49);
            btnCustomerSearch.Name = "btnCustomerSearch";
            btnCustomerSearch.Size = new Size(94, 29);
            btnCustomerSearch.TabIndex = 5;
            btnCustomerSearch.Text = "Search";
            btnCustomerSearch.UseVisualStyleBackColor = true;
            btnCustomerSearch.Click += btnCustomerSearch_Click;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(6, 84);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(123, 20);
            lblCustomerName.TabIndex = 6;
            lblCustomerName.Text = "Customer Name :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(135, 84);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(789, 27);
            txtCustomerName.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(59, 117);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(134, 117);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(790, 27);
            txtAddress.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(75, 155);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(135, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(789, 27);
            txtEmail.TabIndex = 11;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(59, 189);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(67, 20);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact :";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(134, 189);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(220, 27);
            txtContact.TabIndex = 13;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(382, 189);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(128, 20);
            lblPaymentMethod.TabIndex = 14;
            lblPaymentMethod.Text = "Payment Method :";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(516, 189);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(168, 28);
            cmbPaymentMethod.TabIndex = 15;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(135, 247);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(106, 20);
            lblProductCode.TabIndex = 16;
            lblProductCode.Text = "Product Code :";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(135, 270);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(183, 27);
            txtProductCode.TabIndex = 17;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(324, 270);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(71, 29);
            btnSearchProduct.TabIndex = 18;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // lblBatchCode
            // 
            lblBatchCode.AutoSize = true;
            lblBatchCode.Location = new Point(401, 249);
            lblBatchCode.Name = "lblBatchCode";
            lblBatchCode.Size = new Size(92, 20);
            lblBatchCode.TabIndex = 19;
            lblBatchCode.Text = "Batch Code :";
            // 
            // txtBatchCode
            // 
            txtBatchCode.Location = new Point(401, 272);
            txtBatchCode.Name = "txtBatchCode";
            txtBatchCode.ReadOnly = true;
            txtBatchCode.Size = new Size(125, 27);
            txtBatchCode.TabIndex = 20;
            // 
            // lblUnitCode
            // 
            lblUnitCode.AutoSize = true;
            lblUnitCode.Location = new Point(532, 249);
            lblUnitCode.Name = "lblUnitCode";
            lblUnitCode.Size = new Size(82, 20);
            lblUnitCode.TabIndex = 21;
            lblUnitCode.Text = "Unit Code :";
            // 
            // txtUnitCode
            // 
            txtUnitCode.Location = new Point(532, 272);
            txtUnitCode.Name = "txtUnitCode";
            txtUnitCode.ReadOnly = true;
            txtUnitCode.Size = new Size(125, 27);
            txtUnitCode.TabIndex = 22;
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Location = new Point(663, 249);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(90, 20);
            lblSellingPrice.TabIndex = 23;
            lblSellingPrice.Text = "Selling Price";
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(663, 272);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.ReadOnly = true;
            txtSellingPrice.Size = new Size(125, 27);
            txtSellingPrice.TabIndex = 24;
            // 
            // lblPurchaseQty
            // 
            lblPurchaseQty.AutoSize = true;
            lblPurchaseQty.Location = new Point(794, 249);
            lblPurchaseQty.Name = "lblPurchaseQty";
            lblPurchaseQty.Size = new Size(94, 20);
            lblPurchaseQty.TabIndex = 25;
            lblPurchaseQty.Text = "Purchase Qty";
            // 
            // txtPurchaseQty
            // 
            txtPurchaseQty.Location = new Point(794, 272);
            txtPurchaseQty.Name = "txtPurchaseQty";
            txtPurchaseQty.Size = new Size(125, 27);
            txtPurchaseQty.TabIndex = 26;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(135, 300);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(111, 20);
            lblProductName.TabIndex = 27;
            lblProductName.Text = "Product Name :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(135, 323);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(666, 27);
            txtProductName.TabIndex = 28;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(825, 321);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 29;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 356);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1063, 223);
            dataGridView1.TabIndex = 30;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(787, 604);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(87, 20);
            lblTotalSales.TabIndex = 31;
            lblTotalSales.Text = "Total Sales :";
            // 
            // txtTotalPurchase
            // 
            txtTotalPurchase.Location = new Point(880, 601);
            txtTotalPurchase.Name = "txtTotalPurchase";
            txtTotalPurchase.ReadOnly = true;
            txtTotalPurchase.Size = new Size(228, 27);
            txtTotalPurchase.TabIndex = 32;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1014, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1014, 47);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 34;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 697);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtTotalPurchase);
            Controls.Add(lblTotalSales);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddProduct);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(txtPurchaseQty);
            Controls.Add(lblPurchaseQty);
            Controls.Add(txtSellingPrice);
            Controls.Add(lblSellingPrice);
            Controls.Add(txtUnitCode);
            Controls.Add(lblUnitCode);
            Controls.Add(txtBatchCode);
            Controls.Add(lblBatchCode);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtProductCode);
            Controls.Add(lblProductCode);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(lblPaymentMethod);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(btnCustomerSearch);
            Controls.Add(txtCustomerCode);
            Controls.Add(lblCustomerCode);
            Controls.Add(btnSalesSearch);
            Controls.Add(txtSalesCode);
            Controls.Add(lblSalesCode);
            Name = "SalesForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalesCode;
        private TextBox txtSalesCode;
        private Button btnSalesSearch;
        private Label lblCustomerCode;
        private TextBox txtCustomerCode;
        private Button btnCustomerSearch;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private Label lblProductCode;
        private TextBox txtProductCode;
        private Button btnSearchProduct;
        private Label lblBatchCode;
        private TextBox txtBatchCode;
        private Label lblUnitCode;
        private TextBox txtUnitCode;
        private Label lblSellingPrice;
        private TextBox txtSellingPrice;
        private Label lblPurchaseQty;
        private TextBox txtPurchaseQty;
        private Label lblProductName;
        private TextBox txtProductName;
        private Button btnAddProduct;
        private DataGridView dataGridView1;
        private Label lblTotalSales;
        private TextBox txtTotalPurchase;
        private Button btnSave;
        private Button btnClear;
    }
}