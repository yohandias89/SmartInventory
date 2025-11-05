using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Services;
using System.Text.RegularExpressions;

namespace SmartInventory.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly Employee? employee = new();
        public EmployeeForm(Employee? employee = null)
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            this.employee = employee;
            this.Load += EmployeeForm_Load;

        }

        private void EmployeeForm_Load(object? sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void LoadEmployee()
        {
            if (employee != null) {
                txtEmployeeCode.Text = employee.EmployeeCode;
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtDateOfBirth.Text = employee.DateOfBirth.ToString("yyy-MM-dd");
                txtNIC.Text = employee.NIC;
                txtAddress.Text = employee.Address;
                txtEmail.Text = employee.Email;
                txtContact.Text = employee.Contact;

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private bool FieldValidate()
        {
            errpEmployeeForm.Clear();
            bool isValidate = true;
            if(string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errpEmployeeForm.SetError(txtFirstName, "First name is required.");
                isValidate = false; 
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errpEmployeeForm.SetError(txtLastName, "Last name is required.");
                isValidate = false;
            }
            if (string.IsNullOrWhiteSpace(txtDateOfBirth.Text)) {
                errpEmployeeForm.SetError(txtDateOfBirth, "Date of birth is required.");
                isValidate = false;
            }else if (!Regex.IsMatch(txtDateOfBirth.Text, @"^\d{4}-\d{2}-\d{2}$"))
            {
                errpEmployeeForm.SetError(txtDateOfBirth, "Date of birth should be a valid date format 1900-01-01");
                isValidate = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errpEmployeeForm.SetError(txtNIC, "NIC is required.");
                isValidate = false;
            } else if (!Regex.IsMatch(txtNIC.Text, @"(^\d{9}[vVxX]|^\d{12})$"))
            {
                errpEmployeeForm.SetError(txtNIC, "NIC should be in a valid format.");
                isValidate = false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text)) 
            {
                errpEmployeeForm.SetError(txtAddress, "Address is required");
                isValidate = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errpEmployeeForm.SetError(txtEmail, "Email is required.");
                isValidate = false;
            }else if(!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errpEmployeeForm.SetError(txtEmail, "Email should be a valid email.");
                isValidate = false;
            }
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                errpEmployeeForm.SetError(txtContact, "Contact is required");
                isValidate = false;
            }else if(!Regex.IsMatch(txtContact.Text, @"^0\d{9}$"))
            {
                errpEmployeeForm.SetError(txtContact, "Contact should be valid 10 dights phone number");
                isValidate = false;
            }
              return isValidate;
        }

        private bool DataValidate()
        { 
            bool isValidate = true;
            try
            {
                if (EmployeeService.IsExistingNIC(txtNIC.Text))
                {
                    errpEmployeeForm.SetError(txtNIC, "NIC already exists");
                    isValidate = false;
                }
                if (EmployeeService.IsExistingEmail(txtEmail.Text))
                {
                    errpEmployeeForm.SetError(txtEmail, "Email already exists");
                    isValidate = false;
                }
                if (EmployeeService.IsExistingContact(txtContact.Text))
                {
                    errpEmployeeForm.SetError(txtContact, "Contact already exists");
                    isValidate = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValidate = false;
            }
            return isValidate;
        }

        private bool FormValidate()
        {
            bool isFiledValidate = FieldValidate();
            bool isDataValidate = DataValidate();
            return isFiledValidate && isDataValidate;
        }


        private void FormClear()
        {
            txtEmployeeCode.Text = string.Empty;
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
                string generatedCode = EmployeeService.GetEmployeeCode();
                Employee employee = new()
                {
                    EmployeeCode = generatedCode,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(txtDateOfBirth.Text)),
                    NIC = txtNIC.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Contact = txtContact.Text,
                    CreatedBy = "admin", // TODO: Replace with logged in user
                    UpdatedBy = "admin"  // TODO: Replace with logged in user
                };
                EmployeeService.CreateEmployee(employee);
                MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClear();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!FieldValidate())
            {
                return;
            }
            try
            { 
                EmployeeUpdateModel employee = new()
                {
                    EmployeeCode = txtEmployeeCode.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(txtDateOfBirth.Text)),
                    NIC = txtNIC.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Contact = txtContact.Text,
                    UpdatedBy = "admin" // TODO: Replace with logged in user
                };
                EmployeeService.UpdateEmployee(employee);
                MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClear();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!FieldValidate())
            {
                return;
            }
            try
            {
                EmployeeService.DeleteEmployee(txtEmployeeCode.Text);
                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClear();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }
    }
}
