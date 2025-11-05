using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class EmployeeList : Form
    {
        private List<Employee> employees = [];
        BindingSource bindingSource = new BindingSource();

        private int totalRecords = 0;
        private int totalPages = 0;
        private int pageSize = 10;
        private int currentPage = 1;
        private string filterFirstName = "";
        private string filterLastName = "";
        private string filterNIC = "";
        private string filterEmail = "";
        private string filterContact = "";
        public EmployeeList()
        {
            InitializeComponent();
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EmployeeCode",
                HeaderText = "Employee Code"
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "First Name"
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Last Name"
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DateOfBirth",
                HeaderText = "Date of Birth",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyy-MM-dd"
                }
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NIC",
                HeaderText = "NIC"
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                HeaderText = "Address"
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Contact",
                HeaderText = "Contact"
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Created At",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyy-MM-dd HH:mm"
                }

            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedBy",
                HeaderText = "Created By"
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdatedAt",
                HeaderText = "Updated At",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyy-MM-dd HH:mm"
                }
            });
            dgvEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdatedBy",
                HeaderText = "Updated By"
            });


            this.Load += EmployeeList_Load;
            dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
        }

        private void DgvEmployees_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < employees.Count)
            {
                Employee employee = employees[e.RowIndex];
                if (employee != null)
                {
                    EmployeeForm employeeForm = new EmployeeForm(employee);
                    if(employeeForm.ShowDialog() == DialogResult.OK)
                    {
                        GetEmployees(currentPage);
                    }
                }
            }
        }

        private void EmployeeList_Load(object? sender, EventArgs e)
        {
            GetEmployees(currentPage);
        }

        private void GetEmployees(int currentPage)
        {
            dgvEmployees.DataSource = null;

            try
            {
                employees = EmployeeService.GetPaginatedEmployees(
                out totalRecords,
                out totalPages,
                pageSize,
                currentPage,
                filterFirstName,
                filterLastName,
                filterNIC,
                filterEmail,
                filterContact
                );

                bindingSource.DataSource = employees;
                dgvEmployees.DataSource = bindingSource;
                txtPageInfo.Text = $"{currentPage} of {totalPages}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            filterFirstName = txtFirstName.Text.Trim();
            filterLastName = txtLastName.Text.Trim();
            filterNIC = txtNIC.Text.Trim();
            filterEmail = txtEmail.Text.Trim();
            filterContact = txtContact.Text.Trim();
            currentPage = 1;

            GetEmployees(currentPage);
        }

        private void ClearFilters()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContact.Text = string.Empty;

            filterFirstName = string.Empty;
            filterLastName = string.Empty;
            filterNIC = string.Empty;
            filterEmail = string.Empty;
            filterContact = string.Empty;

            currentPage = 1;
            GetEmployees(currentPage);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            if (employeeForm.ShowDialog() == DialogResult.OK) {
                GetEmployees(currentPage);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if(currentPage > 1)
            {
                currentPage--;
                GetEmployees(currentPage);
            }

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                GetEmployees(currentPage);
            }
        }
    }
}
