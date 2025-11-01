namespace SmartInventory.Forms
{
    partial class ProductSearchDialog
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
            dgvSerchedProducts = new DataGridView();
            label1 = new Label();
            txtBarcodeNo = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            btnSearch = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPageInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSerchedProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvSerchedProducts
            // 
            dgvSerchedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSerchedProducts.Location = new Point(0, 65);
            dgvSerchedProducts.Name = "dgvSerchedProducts";
            dgvSerchedProducts.RowHeadersWidth = 51;
            dgvSerchedProducts.Size = new Size(1178, 354);
            dgvSerchedProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Barcode No :";
            // 
            // txtBarcodeNo
            // 
            txtBarcodeNo.Location = new Point(12, 32);
            txtBarcodeNo.Name = "txtBarcodeNo";
            txtBarcodeNo.Size = new Size(266, 27);
            txtBarcodeNo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 9);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Product Name :";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(284, 32);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(265, 27);
            txtProductName.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(555, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(432, 425);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 29);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "<<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += BtnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(532, 423);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 7;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // lblPageInfo
            // 
            lblPageInfo.Location = new Point(632, 425);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(125, 27);
            lblPageInfo.TabIndex = 8;
            // 
            // ProductSearchDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 458);
            Controls.Add(lblPageInfo);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnSearch);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(txtBarcodeNo);
            Controls.Add(label1);
            Controls.Add(dgvSerchedProducts);
            Name = "ProductSearchDialog";
            Text = "ProductSearchDialog";
            ((System.ComponentModel.ISupportInitialize)dgvSerchedProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSerchedProducts;
        private Label label1;
        private TextBox txtBarcodeNo;
        private Label label2;
        private TextBox txtProductName;
        private Button btnSearch;
        private Button btnPrevious;
        private Button btnNext;
        private TextBox lblPageInfo;
    }
}