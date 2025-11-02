
using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class ProductForm : Form
    {
        private List<Category> categories = new List<Category>();
        private List<SubCategory> subCategories = new List<SubCategory>();
        public ProductForm()
        {
            InitializeComponent();
            this.Load += Form_Load;
            cmbCategoryCode.SelectedIndexChanged += CmbCategoryCode_SelectedIndexChanged;

        }

        private void CmbCategoryCode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            subCategories = SubCategoryService.GetSubCategoriesByCategoryCode(cmbCategoryCode.SelectedValue.ToString() ?? string.Empty);
            BindingSource bindingSource = new()
            {
                DataSource = subCategories
            };
            cmbSubCategoryCode.DataSource = bindingSource;
            cmbSubCategoryCode.DisplayMember = "SubCategoryName";
            cmbSubCategoryCode.ValueMember = "SubCategoryCode";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            GetCategories();
        }

        private void GetCategories()
        {
            categories = CategoryService.GetCategories();
            BindingSource bindingSource = new()
            {
                DataSource = categories
            };
            cmbCategoryCode.DataSource = bindingSource;
            cmbCategoryCode.DisplayMember = "CategoryName";
            cmbCategoryCode.ValueMember = "CategoryCode";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Product product = new Product()
                {
                    CategoryCode = cmbCategoryCode.SelectedValue.ToString() ?? string.Empty,
                    SubCategoryCode = cmbSubCategoryCode.SelectedValue.ToString() ?? string.Empty,
                    ProductCode = txtProductCode.Text,
                    ProductName = txtProductName.Text,
                    NextBatchNo = int.Parse(txtNextNo.Text)
                };

                ProductService.CreateProduct(product);
                MessageBox.Show("Product saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
