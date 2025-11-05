using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms.CustomerForms
{
    public partial class CustomerList : Form
    {
        private List<Customer> customers = new();
        private BindingSource bindingSource = new BindingSource();
        private int totalRecords = 0;
        private int totalPages = 0;
        private int pageSize = 10;
        private int currentPage = 1;

        private string filterFirstName = "";
        private string filterLastName = "";
        private string filterNIC = "";
        private string filterEmail = "";
        private string filterContact = "";

        public CustomerList()
        {
            InitializeComponent();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerCode",
                HeaderText = "Customer Code",
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "First Name"
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Last Name"
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DateOfBirth",
                HeaderText = "Date of Birth",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyy-MM-dd"
                }
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NIC",
                HeaderText = "NIC"
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                HeaderText = "Address"
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Contact",
                HeaderText = "Contact"
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Created At",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyyy-MM-dd HH:mm"
                }

            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedBy",
                HeaderText = "Created By"
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdatedAt",
                HeaderText = "Updated At",
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyyy-MM-dd HH:mm"
                }
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UpdatedBy",
                HeaderText = "Updated By"
            });
            this.Load += CustomerList_Load;
            dgvCustomers.CellDoubleClick += DgvCustomers_CellDoubleClick;
        }

        private void DgvCustomers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customers.Count)
            {
                var selectedEmployee = customers[e.RowIndex];
                if (selectedEmployee != null)
                {
                    CustomerForm customerForm = new CustomerForm(selectedEmployee);
                    if (customerForm.ShowDialog() == DialogResult.OK)
                    {
                        currentPage = 1;
                        LoadCustomers(currentPage);
                    }
                }
            }
        }

        private void CustomerList_Load(object? sender, EventArgs e)
        {
            LoadCustomers(currentPage);
        }
        private void ApplyFilter()
        {
            filterFirstName = txtFirstName.Text.Trim();
            filterLastName = txtLastName.Text.Trim();
            filterNIC = txtNIC.Text.Trim();
            filterEmail = txtEmail.Text.Trim();
            filterContact = txtContact.Text.Trim();
            currentPage = 1;
            LoadCustomers(currentPage);
        }
        private void ClearFilter()
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
            LoadCustomers(currentPage);
        }

        private void LoadCustomers(int currentPage)
        {
            customers = CustomerService.GetPaginatedCustomers(
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

            bindingSource.DataSource = customers;
            dgvCustomers.DataSource = bindingSource;
            txtPageInfo.Text = $"Page {currentPage} of {totalPages}";
        }



        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();


        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadCustomers(currentPage);

            }

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadCustomers(currentPage);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                currentPage = 1;
                LoadCustomers(currentPage);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }
    }
}
