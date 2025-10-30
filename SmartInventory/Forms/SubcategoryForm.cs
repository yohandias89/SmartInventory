

using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class SubcategoryForm : Form
    {
        private List<SubCategory> subCategories = [];
        private List<Category> categories = [];
        public SubcategoryForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadSubCategories();
            btnUpdate.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void LoadSubCategories()
        {
            subCategories = SubCategoryService.GetSubCategories();
            dgvSubCatgories.DataSource = null;
            BindingSource bindingSource = new()
            {
                DataSource = subCategories
            };
            dgvSubCatgories.DataSource = bindingSource;

        }

        private void LoadCategories()
        {
            cmbCategoryCode.DataSource = null;
            categories = CategoryService.GetCategories();
            BindingSource bindingSource = new()
            {
                DataSource = categories
            };
            cmbCategoryCode.DataSource = bindingSource;
            cmbCategoryCode.ValueMember = "CategoryCode";
            cmbCategoryCode.DisplayMember = "CategoryName";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SubCategory subCategory = new()
                {
                    CategoryCode = cmbCategoryCode.SelectedValue.ToString(),
                    SubCategoryCode = txtSubCategoryCode.Text,
                    SubCategoryName = txtSubCategoryName.Text,
                    CreatedBy = "EMP00001",
                    UpdatedBy = "EMP00001"
                };

                bool result = SubCategoryService.CreateSubCategory(subCategory);
                if (result)
                {
                    MessageBox.Show("Category created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
