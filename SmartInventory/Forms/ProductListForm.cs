

using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class ProductListForm : Form
    {
        private List<Product> products = [];
        private BindingSource bindingSource = new();
        private int totalRecords = 0;
        private int pageSize = 10;
        private int currentPage = 1;
        private int totalPages = 0;
        private string filterCategoryCode = "";
        private string filterSubCategoryCode = "";
        private string filterProductCode = "";
        private string filterProductName = "";

        public ProductListForm()
        {
            InitializeComponent();
            this.Load += ProductListForm_Load;
        }

        private void ProductListForm_Load(object? sender, EventArgs e)
        {
            LoadProducts(1);
        }

        private void LoadProducts(int pageNumber)
        {
            products = ProductService.SearchProducts(
                out totalRecords,
                out totalPages,
                pageSize,
                currentPage,
                filterCategoryCode,
                filterSubCategoryCode,
                filterProductCode,
                filterProductName
            );
            
            bindingSource.DataSource = products;
            dgvSearchedProductList.DataSource = bindingSource;
            txtPageInfo.Text = $"Page {currentPage} of {totalPages}";
        }

        private void ApplyFilters()
        {
            filterCategoryCode = txtCategoryCode.Text.Trim();
            filterSubCategoryCode = txtSubCategoryCode.Text.Trim();
            filterProductCode = txtProductCode.Text.Trim();
            filterProductName = txtProductName.Text.Trim();
            currentPage = 1;
            LoadProducts(currentPage);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.FormClosed += (s, args) => LoadProducts(currentPage);
            productForm.ShowDialog();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadProducts(currentPage);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadProducts(currentPage);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}
