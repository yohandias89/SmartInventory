using Microsoft.Data.SqlClient;
using SmartInventory.Database;
using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class ProductSearchDialog : Form
    {
        private List<ProductSearchModel> searchModels = [];
        private BindingSource bindingSource = new();
        private int totalRecords = 0;
        private int pageSize = 10;
        private int currentPage = 1;
        private int totalPages = 0;
        private string filterBarcode = "";
        private string filterProductName = "";
        public ProductSearchModel SelectedProduct {get; set; } = null!;


        public ProductSearchDialog()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ProductSearchDialog_Load);
            dgvSerchedProducts.CellDoubleClick += DataGridView1_CellDoubleClick;

        }

        private void DataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSerchedProducts.Rows[e.RowIndex].DataBoundItem is ProductSearchModel product)
            {
                SelectedProduct  = product;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ProductSearchDialog_Load(object? sender, EventArgs e)
        {
            LoadPage(1);
        }

        private void LoadPage(int pageNumber)
        {
            searchModels = ProductDetailService.GetProductsSearchDetails(
                out totalRecords,
                out totalPages,
                pageSize,
                pageNumber,
                filterBarcode,
                filterProductName);

            dgvSerchedProducts.DataSource = null;
            bindingSource.DataSource = searchModels;
            dgvSerchedProducts.DataSource = bindingSource;

            txtPageInfo.Text = $"Page {currentPage} of {totalPages}";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplyProductFilter();

        }

        private void ApplyProductFilter()
        {
            filterBarcode = txtBarcodeNo.Text.Trim();
            filterProductName = txtProductName.Text.Trim();
            currentPage = 1;
            LoadPage(currentPage);
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage(currentPage);
            }

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage(currentPage);
            }
        }
    }
}
