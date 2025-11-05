using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Services;
using System.Text.RegularExpressions;

namespace SmartInventory.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly Customer? _customer;
        public CustomerForm(Customer? customer = null)
        {
            InitializeComponent();
            this.Load += CustomerForm_Load;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            _customer = customer;
        }

        private void CustomerForm_Load(object? sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            if (_customer != null)
            {
                txtCustomerCode.Text = _customer.CustomerCode;
                txtFirstName.Text = _customer.FirstName;
                txtLastName.Text = _customer.LastName;
                txtDateOfBirth.Text = _customer.DateOfBirth.ToString("yyyy-MM-dd");
                txtNIC.Text = _customer.NIC;
                txtAddress.Text = _customer.Address;
                txtEmail.Text = _customer.Email;
                txtContact.Text = _customer.Contact;

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private bool FiledValidation()
        {
            errpCustomerForm.Clear();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {

                errpCustomerForm.SetError(txtFirstName, "First name is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errpCustomerForm.SetError(txtLastName, "Last name is required.");
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtDateOfBirth.Text))
            {
                errpCustomerForm.SetError(txtDateOfBirth, "Date of birth is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtDateOfBirth.Text, @"^\d{4}-\d{2}-\d{2}$"))
            {
                errpCustomerForm.SetError(txtDateOfBirth, "Date of birth should be in a valid date format 1990-01-01");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                errpCustomerForm.SetError(txtNIC, "NIC is required.");
                isValid = false;
            }
            else if (!Regex.IsMatch(txtNIC.Text, @"(^\d{9}[vVxX]$|^\d{12})$"))
            {
                errpCustomerForm.SetError(txtNIC, "NIC not in the valid format");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errpCustomerForm.SetError(txtAddress, "Address is required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errpCustomerForm.SetError(txtEmail, "Email is required");
                isValid = false;
            }
            else if(!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                    errpCustomerForm.SetError(txtEmail, "Email should be a valid email address");
                    isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                errpCustomerForm.SetError(txtContact, "Contact is required");
                isValid = false;

            }
            else if (!Regex.IsMatch(txtContact.Text, @"^0\d{9}$"))
            {
                    errpCustomerForm.SetError(txtContact, "Contact should be a valid 10 digit contact number");
                    isValid = false;
            }
            return isValid;
        }

        private bool ValidateExistingData(string nic, string email, string contact)
        {
            bool isValid = true;
            try
            {
                if (CustomerService.IsExistingNIC(nic))
                {
                    errpCustomerForm.SetError(txtNIC, "NIC is already exists");
                    isValid = false;
                }
                if (CustomerService.IsExistingEmail(email))
                {
                    errpCustomerForm.SetError(txtEmail, "Email already exists");
                    isValid = false;
                }
                if (CustomerService.IsExistingContact(contact))
                {
                    errpCustomerForm.SetError(txtContact, "Contact already exists");
                    isValid = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;

        }

        private bool FormValidate()
        {
            bool filedValidate = FiledValidation();
            bool dataValidation = ValidateExistingData(txtNIC.Text, txtEmail.Text, txtContact.Text);
            return filedValidate && dataValidation;
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!FormValidate())
            {
                return;
            }

            try
            {
                string generatedCustomerCode = CustomerService.GenerateCustomerCode();
                Customer newCustomer = new()
                {
                    CustomerCode = generatedCustomerCode,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(txtDateOfBirth.Text.Trim())),
                    NIC = txtNIC.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Contact = txtContact.Text.Trim()
                };
                CustomerService.CreateCustomer(newCustomer);
                MessageBox.Show("Customer created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!FiledValidation())
            {
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
                ClearForm();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerCode.Text.Trim()))
            {
                MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                CustomerService.DeleteCustomer(txtCustomerCode.Text);
                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                DialogResult = DialogResult.OK;
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
