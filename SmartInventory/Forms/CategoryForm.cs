using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Services;
using System.Text.RegularExpressions;
namespace SmartInventory.Forms
{
    public partial class CategoryForm : Form
    {
        private List<Category> categories = [];
        private int totalRecords = 0;
        private int totalPages = 0;
        private int pageSize = 10;
        private int currentPage = 1;
        public CategoryForm()
        {
            InitializeComponent();
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn { 
                DataPropertyName = "CategoryCode",
                HeaderText = "Category Code"
            });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryName",
                HeaderText = "Category Name"
            });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Padding",
                HeaderText = "Padding"
            });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NextNo",
                HeaderText = "Next No"
            });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Created At",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyyy-MM-dd HH:mm"
                }

            });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedBy",
                HeaderText = "Created By"
            });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdatedAt",
                HeaderText = "Updated At",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyyy-MM-dd HH:mm"
                }
            });
            dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdatedBy",
                HeaderText = "Updated By"
            });

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            dgvCategories.CellDoubleClick += DgvCategories_CellDoubleClick;

        }

        private void CategoryForm_Load(object? sender, EventArgs e)
        {
            LoadCategories(currentPage);
        }

        private void LoadCategories(int currentPage)
        {
            dgvCategories.DataSource = null;
            categories = CategoryService.GetPaginatedCategories(
                out totalRecords,
                out totalPages,
                pageSize,
                currentPage
                );
            BindingSource bindingSource = new()
            {
                DataSource = categories
            };
            dgvCategories.DataSource = bindingSource;
            txtPageInfo.Text = $"Page {currentPage} of {totalPages}";

        }

        private void ResetForm()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            errpCategory.Clear();

            txtCategoryCode.ReadOnly = false;
            txtCategoryCode.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtPadding.Text = string.Empty;
            txtNextNo.Text = string.Empty;
        }

        private bool ValidateForm()
        {
            errpCategory.Clear();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtCategoryCode.Text))
            {
                errpCategory.SetError(txtCategoryCode, "Category Code is required.");
                isValid = false;
            }
            else
            {
                if (!Regex.IsMatch(txtCategoryCode.Text, "^[A-Z]{4}$"))
                {
                    errpCategory.SetError(txtCategoryCode, "Category Code must be exactly 4 uppercase letters.");
                    isValid = false;
                }
            }
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                errpCategory.SetError(txtCategoryName, "Category Name is required.");
                isValid = false;
            }
            else
            {
                if (txtCategoryName.Text.Length > 100)
                {
                    errpCategory.SetError(txtCategoryName, "Category Name cannot exceed 100 characters.");
                    isValid = false;
                }
            }
            if (!int.TryParse(txtPadding.Text, out _))
            {
                errpCategory.SetError(txtPadding, "Padding must be a valid number.");
                isValid = false;
            }
            if (!int.TryParse(txtNextNo.Text, out _))
            {
                errpCategory.SetError(txtNextNo, "NextNo must be a valid number.");
                isValid = false;
            }
            return isValid;
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to save this category?", "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!ValidateForm())
                {
                    return;
                }
                if (CategoryService.IsCategoryCodeExists(txtCategoryCode.Text))
                {
                    errpCategory.SetError(txtCategoryCode, "Category Code already exists.");
                    return;
                }

                int padding = int.Parse(txtPadding.Text);
                int nextNo = int.Parse(txtNextNo.Text);

                Category category = new()
                {
                    CategoryCode = txtCategoryCode.Text,
                    CategoryName = txtCategoryName.Text,
                    Padding = padding,
                    NextNo = nextNo,
                    CreatedBy = "EMP00001",
                    UpdatedBy = "EMP00001"
                };


                try
                {
                    CategoryService.CreateCategory(category);
                    MessageBox.Show("Category created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    LoadCategories(currentPage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to update this category?", "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!ValidateForm())
                {
                    return;
                }
                CategoryUpdateModel category = new()
                {
                    CategoryCode = txtCategoryCode.Text,
                    CategoryName = txtCategoryName.Text,
                    Padding = Convert.ToInt32(txtPadding.Text),
                    NextNo = Convert.ToInt32(txtNextNo.Text),
                    UpdatedBy = "EMP00001"
                };

                try
                {
                    CategoryService.CategoryUpdate(category);
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    LoadCategories(currentPage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this category?", "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (!ValidateForm())
                {
                    return;
                }
                string categoryCode = txtCategoryCode.Text;

                try
                {
                    CategoryService.DeleteCategory(categoryCode);
                    MessageBox.Show("category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    LoadCategories(currentPage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Are you sure you want to clear the form?", "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetForm();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadCategories(currentPage);
            }

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadCategories(currentPage);
            }

        }


    }
}
