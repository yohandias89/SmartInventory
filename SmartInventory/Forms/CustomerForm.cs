using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class CustomerForm : Form
    {
        private List<Customer> customers = [];
        public CustomerForm()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            LoadCustomers();
            dgvCustomers.CellDoubleClick += DgvCustomers_CellDoubleClick;
        }

        private void ValidateForm()
        {
            // Implement form validation logic here
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                throw new Exception("First Name is required.");
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                throw new Exception("Last Name is required.");
            }
        }

        private void DgvCustomers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < customers.Count)
            {
                Customer selectedCustomer = customers[e.RowIndex];
                txtCustomerCode.Text = selectedCustomer.CustomerCode;
                txtFirstName.Text = selectedCustomer.FirstName;
                txtLastName.Text = selectedCustomer.LastName;
                txtDateOfBirth.Text = selectedCustomer.DateOfBirth.ToString("yyyy-MM-dd");
                txtNIC.Text = selectedCustomer.NIC;
                txtAddress.Text = selectedCustomer.Address;
                txtEmail.Text = selectedCustomer.Email;
                txtContact.Text = selectedCustomer.Contact;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void ClearForm()
        {
            txtCustomerCode.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtContact.Text = string.Empty;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadCustomers()
        {
            try
            {
                dgvCustomers.DataSource = null;
                customers = CustomerService.GetCustomers();
                BindingSource bindingSource = new()
                {
                    DataSource = customers
                };
                dgvCustomers.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateForm();

                string generatedCustomerCode = CustomerService.GenerateCustomerCode();
                Customer newCustomer = new()
                {
                    CustomerCode = generatedCustomerCode,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(txtDateOfBirth.Text)),
                    NIC = txtNIC.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Contact = txtContact.Text
                };
                CustomerService.CreateCustomer(newCustomer);
                MessageBox.Show("Customer created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCustomerCode.Text))
            {
                MessageBox.Show("Please select a customer to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                CustomerUpdateModel updatedCustomer = new()
                {
                    CustomerCode = txtCustomerCode.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(txtDateOfBirth.Text)),
                    NIC = txtNIC.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Contact = txtContact.Text
                };
                CustomerService.UpdateCustomer(updatedCustomer);
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtCustomerCode.Text))
            {
                MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                CustomerService.DeleteCustomer(txtCustomerCode.Text);
                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
