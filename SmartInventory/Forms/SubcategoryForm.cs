

using SmartInventory.DataTransferObjects;
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
            btnDelete.Enabled = false;

            dgvSubCategories.CellDoubleClick += DgvSubCategories_CellDoubleClick;
        }

        private void DgvSubCategories_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubCategories.Rows[e.RowIndex];
                txtSubCategoryCode.Text = row.Cells["SubCategoryCode"].Value.ToString();
                txtSubCategoryName.Text = row.Cells["SubCategoryName"].Value.ToString();
                cmbCategoryCode.SelectedValue = row.Cells["CategoryCode"].Value.ToString();
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void LoadSubCategories()
        {
            subCategories = SubCategoryService.GetSubCategories();
            dgvSubCategories.DataSource = null;
            BindingSource bindingSource = new()
            {
                DataSource = subCategories
            };
            dgvSubCategories.DataSource = bindingSource;

        }
        private void ClearForm()
        {
            txtSubCategoryCode.Clear();
            txtSubCategoryName.Clear();
            cmbCategoryCode.SelectedIndex = -1;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
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
                    ClearForm();
                    LoadSubCategories();
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
            try
            {
                string subCategoryCode = txtSubCategoryCode.Text;
                bool result = SubCategoryService.DeleteSubCategory(subCategoryCode);
                if (result)
                {
                    ClearForm();
                    LoadSubCategories();
                    MessageBox.Show("Category deleted successfully!");
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
                SubCategoryUpdateModel subCategory = new()
                {
                    CategoryCode = cmbCategoryCode.SelectedValue.ToString(),
                    SubCategoryCode = txtSubCategoryCode.Text,
                    SubCategoryName = txtSubCategoryName.Text,
                    UpdatedBy = "EMP00001"
                };

                bool result = SubCategoryService.UpdateSubCategory(subCategory);
                if (result)
                {
                    ClearForm();
                    LoadSubCategories();
                    MessageBox.Show("Category updated successfully!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
