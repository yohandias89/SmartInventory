namespace SmartInventory.Forms
{
    partial class PurchaseForm
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
            lblPurchaseCode = new Label();
            txtPurchaseCode = new TextBox();
            label1 = new Label();
            txtSupplierCode = new TextBox();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblRemarks = new Label();
            txtRemarks = new RichTextBox();
            label2 = new Label();
            cmbPaymentMethod = new ComboBox();
            lblBarcodeNo = new Label();
            txtBarcodeNo = new TextBox();
            btnProductSearch = new Button();
            lblBatchCode = new Label();
            txtBatchCode = new TextBox();
            lbUniCode = new Label();
            txtUnitCode = new TextBox();
            label4 = new Label();
            txtPurchasePrice = new TextBox();
            lblPurchaseQty = new Label();
            txtPurchaseQty = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            dgvPurchaseDetailes = new DataGridView();
            lblTotalPurchase = new Label();
            txtTotalPurchase = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnSearchPurchases = new Button();
            btnSearchSuppliers = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseDetailes).BeginInit();
            SuspendLayout();
            // 
            // lblPurchaseCode
            // 
            lblPurchaseCode.AutoSize = true;
            lblPurchaseCode.Location = new Point(27, 9);
            lblPurchaseCode.Name = "lblPurchaseCode";
            lblPurchaseCode.Size = new Size(113, 20);
            lblPurchaseCode.TabIndex = 0;
            lblPurchaseCode.Text = "Purchase Code :";
            // 
            // txtPurchaseCode
            // 
            txtPurchaseCode.Location = new Point(146, 9);
            txtPurchaseCode.Name = "txtPurchaseCode";
            txtPurchaseCode.ReadOnly = true;
            txtPurchaseCode.Size = new Size(237, 27);
            txtPurchaseCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 46);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Supplier Code :";
            // 
            // txtSupplierCode
            // 
            txtSupplierCode.Location = new Point(146, 46);
            txtSupplierCode.Name = "txtSupplierCode";
            txtSupplierCode.ReadOnly = true;
            txtSupplierCode.Size = new Size(237, 27);
            txtSupplierCode.TabIndex = 3;
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(25, 82);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(115, 20);
            lblSupplierName.TabIndex = 4;
            lblSupplierName.Text = "Supplier Name :";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(146, 82);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(688, 27);
            txtSupplierName.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(71, 115);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(146, 115);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(691, 27);
            txtAddress.TabIndex = 7;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Location = new Point(68, 151);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(72, 20);
            lblRemarks.TabIndex = 8;
            lblRemarks.Text = "Remarks :";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(146, 148);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(696, 75);
            txtRemarks.TabIndex = 9;
            txtRemarks.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 229);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 10;
            label2.Text = "Payment Method :";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(146, 229);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(239, 28);
            cmbPaymentMethod.TabIndex = 11;
            // 
            // lblBarcodeNo
            // 
            lblBarcodeNo.AutoSize = true;
            lblBarcodeNo.Location = new Point(146, 299);
            lblBarcodeNo.Name = "lblBarcodeNo";
            lblBarcodeNo.Size = new Size(95, 20);
            lblBarcodeNo.TabIndex = 12;
            lblBarcodeNo.Text = "Barcode No :";
            // 
            // txtBarcodeNo
            // 
            txtBarcodeNo.Location = new Point(146, 322);
            txtBarcodeNo.Name = "txtBarcodeNo";
            txtBarcodeNo.Size = new Size(228, 27);
            txtBarcodeNo.TabIndex = 13;
            // 
            // btnProductSearch
            // 
            btnProductSearch.Location = new Point(380, 320);
            btnProductSearch.Name = "btnProductSearch";
            btnProductSearch.Size = new Size(64, 29);
            btnProductSearch.TabIndex = 14;
            btnProductSearch.Text = "Search";
            btnProductSearch.UseVisualStyleBackColor = true;
            btnProductSearch.Click += BtnProductSearch_Click;
            // 
            // lblBatchCode
            // 
            lblBatchCode.AutoSize = true;
            lblBatchCode.Location = new Point(450, 297);
            lblBatchCode.Name = "lblBatchCode";
            lblBatchCode.Size = new Size(92, 20);
            lblBatchCode.TabIndex = 15;
            lblBatchCode.Text = "Batch Code :";
            // 
            // txtBatchCode
            // 
            txtBatchCode.Location = new Point(450, 320);
            txtBatchCode.Name = "txtBatchCode";
            txtBatchCode.ReadOnly = true;
            txtBatchCode.Size = new Size(125, 27);
            txtBatchCode.TabIndex = 16;
            // 
            // lbUniCode
            // 
            lbUniCode.AutoSize = true;
            lbUniCode.Location = new Point(588, 297);
            lbUniCode.Name = "lbUniCode";
            lbUniCode.Size = new Size(82, 20);
            lbUniCode.TabIndex = 17;
            lbUniCode.Text = "Unit Code :";
            // 
            // txtUnitCode
            // 
            txtUnitCode.Location = new Point(588, 320);
            txtUnitCode.Name = "txtUnitCode";
            txtUnitCode.ReadOnly = true;
            txtUnitCode.Size = new Size(77, 27);
            txtUnitCode.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(676, 297);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 19;
            label4.Text = "Purchase Price :";
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(676, 320);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.ReadOnly = true;
            txtPurchasePrice.Size = new Size(125, 27);
            txtPurchasePrice.TabIndex = 20;
            // 
            // lblPurchaseQty
            // 
            lblPurchaseQty.AutoSize = true;
            lblPurchaseQty.Location = new Point(807, 297);
            lblPurchaseQty.Name = "lblPurchaseQty";
            lblPurchaseQty.Size = new Size(101, 20);
            lblPurchaseQty.TabIndex = 21;
            lblPurchaseQty.Text = "Purchase Qty :";
            // 
            // txtPurchaseQty
            // 
            txtPurchaseQty.Location = new Point(807, 320);
            txtPurchaseQty.Name = "txtPurchaseQty";
            txtPurchaseQty.Size = new Size(110, 27);
            txtPurchaseQty.TabIndex = 22;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(146, 352);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(111, 20);
            lblProductName.TabIndex = 23;
            lblProductName.Text = "Product Name :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(146, 375);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(653, 27);
            txtProductName.TabIndex = 24;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(814, 373);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(103, 29);
            btnAddProduct.TabIndex = 25;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += BtnAddProduct_Click;
            // 
            // dgvPurchaseDetailes
            // 
            dgvPurchaseDetailes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseDetailes.Location = new Point(12, 408);
            dgvPurchaseDetailes.Name = "dgvPurchaseDetailes";
            dgvPurchaseDetailes.RowHeadersWidth = 51;
            dgvPurchaseDetailes.Size = new Size(1049, 291);
            dgvPurchaseDetailes.TabIndex = 26;
            // 
            // lblTotalPurchase
            // 
            lblTotalPurchase.AutoSize = true;
            lblTotalPurchase.Location = new Point(701, 724);
            lblTotalPurchase.Name = "lblTotalPurchase";
            lblTotalPurchase.Size = new Size(107, 20);
            lblTotalPurchase.TabIndex = 27;
            lblTotalPurchase.Text = "Total Purchase:";
            // 
            // txtTotalPurchase
            // 
            txtTotalPurchase.Location = new Point(814, 724);
            txtTotalPurchase.Name = "txtTotalPurchase";
            txtTotalPurchase.Size = new Size(247, 27);
            txtTotalPurchase.TabIndex = 28;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(967, 37);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(967, 73);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 30;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearchPurchases
            // 
            btnSearchPurchases.Location = new Point(389, 9);
            btnSearchPurchases.Name = "btnSearchPurchases";
            btnSearchPurchases.Size = new Size(94, 29);
            btnSearchPurchases.TabIndex = 31;
            btnSearchPurchases.Text = "Search";
            btnSearchPurchases.UseVisualStyleBackColor = true;
            btnSearchPurchases.Click += btnSearchPurchases_Click;
            // 
            // btnSearchSuppliers
            // 
            btnSearchSuppliers.Location = new Point(389, 45);
            btnSearchSuppliers.Name = "btnSearchSuppliers";
            btnSearchSuppliers.Size = new Size(94, 29);
            btnSearchSuppliers.TabIndex = 32;
            btnSearchSuppliers.Text = "Search";
            btnSearchSuppliers.UseVisualStyleBackColor = true;
            btnSearchSuppliers.Click += btnSearchSuppliers_Click;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 795);
            Controls.Add(btnSearchSuppliers);
            Controls.Add(btnSearchPurchases);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtTotalPurchase);
            Controls.Add(lblTotalPurchase);
            Controls.Add(dgvPurchaseDetailes);
            Controls.Add(btnAddProduct);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(txtPurchaseQty);
            Controls.Add(lblPurchaseQty);
            Controls.Add(txtPurchasePrice);
            Controls.Add(label4);
            Controls.Add(txtUnitCode);
            Controls.Add(lbUniCode);
            Controls.Add(txtBatchCode);
            Controls.Add(lblBatchCode);
            Controls.Add(btnProductSearch);
            Controls.Add(txtBarcodeNo);
            Controls.Add(lblBarcodeNo);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(label2);
            Controls.Add(txtRemarks);
            Controls.Add(lblRemarks);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtSupplierName);
            Controls.Add(lblSupplierName);
            Controls.Add(txtSupplierCode);
            Controls.Add(label1);
            Controls.Add(txtPurchaseCode);
            Controls.Add(lblPurchaseCode);
            Name = "PurchaseForm";
            Text = "PurchaseForm";
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseDetailes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPurchaseCode;
        private TextBox txtPurchaseCode;
        private Label label1;
        private TextBox txtSupplierCode;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblRemarks;
        private RichTextBox txtRemarks;
        private Label label2;
        private ComboBox cmbPaymentMethod;
        private Label lblBarcodeNo;
        private TextBox txtBarcodeNo;
        private Button btnProductSearch;
        private Label lblBatchCode;
        private TextBox txtBatchCode;
        private Label lbUniCode;
        private TextBox txtUnitCode;
        private Label label4;
        private TextBox txtPurchasePrice;
        private Label lblPurchaseQty;
        private TextBox txtPurchaseQty;
        private Label lblProductName;
        private TextBox txtProductName;
        private Button btnAddProduct;
        private DataGridView dgvPurchaseDetailes;
        private Label lblTotalPurchase;
        private TextBox txtTotalPurchase;
        private Button btnSave;
        private Button btnClear;
        private Button btnSearchPurchases;
        private Button btnSearchSuppliers;
    }
}