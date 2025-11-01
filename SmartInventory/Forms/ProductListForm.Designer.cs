namespace SmartInventory.Forms
{
    partial class ProductListForm
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
            dgvSearchedProductList = new DataGridView();
            lblCategoryCode = new Label();
            txtCategoryCode = new TextBox();
            lblSubCategoryCode = new Label();
            txtSubCategoryCode = new TextBox();
            lblProductCode = new Label();
            txtProductCode = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            btnSearch = new Button();
            btnAddProduct = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            txtPageInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSearchedProductList).BeginInit();
            SuspendLayout();
            // 
            // dgvSearchedProductList
            // 
            dgvSearchedProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchedProductList.Location = new Point(-1, 122);
            dgvSearchedProductList.Name = "dgvSearchedProductList";
            dgvSearchedProductList.RowHeadersWidth = 51;
            dgvSearchedProductList.Size = new Size(1171, 395);
            dgvSearchedProductList.TabIndex = 0;
            // 
            // lblCategoryCode
            // 
            lblCategoryCode.AutoSize = true;
            lblCategoryCode.Location = new Point(12, 9);
            lblCategoryCode.Name = "lblCategoryCode";
            lblCategoryCode.Size = new Size(115, 20);
            lblCategoryCode.TabIndex = 1;
            lblCategoryCode.Text = "Category Code :";
            // 
            // txtCategoryCode
            // 
            txtCategoryCode.Location = new Point(17, 34);
            txtCategoryCode.Name = "txtCategoryCode";
            txtCategoryCode.Size = new Size(125, 27);
            txtCategoryCode.TabIndex = 2;
            // 
            // lblSubCategoryCode
            // 
            lblSubCategoryCode.AutoSize = true;
            lblSubCategoryCode.Location = new Point(148, 9);
            lblSubCategoryCode.Name = "lblSubCategoryCode";
            lblSubCategoryCode.Size = new Size(144, 20);
            lblSubCategoryCode.TabIndex = 3;
            lblSubCategoryCode.Text = "Sub Category Code :";
            // 
            // txtSubCategoryCode
            // 
            txtSubCategoryCode.Location = new Point(148, 32);
            txtSubCategoryCode.Name = "txtSubCategoryCode";
            txtSubCategoryCode.Size = new Size(150, 27);
            txtSubCategoryCode.TabIndex = 4;
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(304, 9);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(106, 20);
            lblProductCode.TabIndex = 5;
            lblProductCode.Text = "Product Code :";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(304, 34);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(125, 27);
            txtProductCode.TabIndex = 6;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(435, 9);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(111, 20);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "Product Name :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(435, 34);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(335, 27);
            txtProductName.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(786, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(17, 87);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(94, 29);
            btnAddProduct.TabIndex = 10;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(449, 531);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 11;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(549, 531);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 12;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtPageInfo
            // 
            txtPageInfo.Location = new Point(649, 533);
            txtPageInfo.Name = "txtPageInfo";
            txtPageInfo.ReadOnly = true;
            txtPageInfo.Size = new Size(125, 27);
            txtPageInfo.TabIndex = 13;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 571);
            Controls.Add(txtPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnAddProduct);
            Controls.Add(btnSearch);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(txtProductCode);
            Controls.Add(lblProductCode);
            Controls.Add(txtSubCategoryCode);
            Controls.Add(lblSubCategoryCode);
            Controls.Add(txtCategoryCode);
            Controls.Add(lblCategoryCode);
            Controls.Add(dgvSearchedProductList);
            Name = "ProductListForm";
            Text = "ProductListForm";
            ((System.ComponentModel.ISupportInitialize)dgvSearchedProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSearchedProductList;
        private Label lblCategoryCode;
        private TextBox txtCategoryCode;
        private Label lblSubCategoryCode;
        private TextBox txtSubCategoryCode;
        private Label lblProductCode;
        private TextBox txtProductCode;
        private Label lblProductName;
        private TextBox txtProductName;
        private Button btnSearch;
        private Button btnAddProduct;
        private Button btnPrevious;
        private Button btnNext;
        private TextBox txtPageInfo;
    }
}