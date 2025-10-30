using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class CategoryForm : Form
    {
        private List<Category> categories = [];
        public CategoryForm()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadCategories();
            dgvCategories.CellDoubleClick += DgvCategories_CellDoubleClick;

        }

        private void RestForm()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtCategoryCode.ReadOnly = false;
            txtCategoryCode.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtPadding.Text = string.Empty;
            txtNextNo.Text = string.Empty;
        }

        private void DgvCategories_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < categories.Count)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;

                txtCategoryCode.ReadOnly = true;

                Category selectedCategory = categories[e.RowIndex];
                txtCategoryCode.Text = selectedCategory.CategoryCode;
                txtCategoryName.Text = selectedCategory.CategoryName;
                txtPadding.Text = selectedCategory.Padding.ToString();
                txtNextNo.Text = selectedCategory.NextNo.ToString();
            }
        }

        private void LoadCategories()
        {
            dgvCategories.DataSource = null;
            categories = CategoryService.GetCategories();
            BindingSource bindingSource = new()
            {
                DataSource = categories
            };
            dgvCategories.DataSource = bindingSource;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new()
                {
                    CategoryCode = txtCategoryCode.Text,
                    CategoryName = txtCategoryName.Text,
                    Padding = Convert.ToInt32(txtPadding.Text),
                    NextNo = Convert.ToInt32(txtNextNo.Text),
                    CreatedBy = "EMP00001",
                    UpdatedBy = "EMP00001"
                };

                bool result = CategoryService.CreateCategory(category);
                if (result)
                {
                    RestForm();
                    LoadCategories();
                    MessageBox.Show("Category created successfully!");
                }
                else
                {
                    MessageBox.Show("Category creation failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                CategoryUpdateModel category = new()
                {
                    CategoryCode = txtCategoryCode.Text,
                    CategoryName = txtCategoryName.Text,
                    Padding = Convert.ToInt32(txtPadding.Text),
                    NextNo = Convert.ToInt32(txtNextNo.Text),
                    UpdatedBy = "EMP00001"
                };
                bool result = CategoryService.CategoryUpdate(category);
                if (result)
                {
                    RestForm();
                    LoadCategories();
                    MessageBox.Show("Category updated successfully!");
                }
                else
                {
                    MessageBox.Show("Category update failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryCode = txtCategoryCode.Text;
                if (!string.IsNullOrEmpty(categoryCode))
                {
                    bool result = CategoryService.DeleteCategory(categoryCode);
                    if (result)
                    {
                        RestForm();
                        LoadCategories();
                        MessageBox.Show("category deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Category delete failed!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select valid category to delete!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            RestForm();
        }
    }
}
