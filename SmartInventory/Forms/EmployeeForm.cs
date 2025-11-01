using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class EmployeeForm : Form
    {
        private List<Employee> employees = [];
        public EmployeeForm()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadEmployees();
            dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
        }

        private void DgvEmployees_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= employees.Count)
            {
                Employee selectedEmployee = employees[e.RowIndex];
                if (selectedEmployee != null)
                {
                    txtEmployeeCode.Text = selectedEmployee.EmployeeCode;
                    txtFirstName.Text = selectedEmployee.FirstName;
                    txtLastName.Text = selectedEmployee.LastName;
                    txtDateOfBirth.Text = selectedEmployee.DateOfBirth.ToString("yyyy-MM-dd");
                    txtNIC.Text = selectedEmployee.NIC;
                    txtAddress.Text = selectedEmployee.Address;
                    txtEmail.Text = selectedEmployee.Email;
                    txtContact.Text = selectedEmployee.Contact;
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = null;
            employees = EmployeeService.GetEmployees();
            BindingSource bindingSource = new()
            {   
                DataSource = employees
            };
            dgvEmployees.DataSource = bindingSource;

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
                LoadEmployees();
                FormClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmployeeCode.Text))
            {
                MessageBox.Show("Please select an employee to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                LoadEmployees();
                FormClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmployeeCode.Text))
            {
                MessageBox.Show("Please select an employee to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                EmployeeService.DeleteEmployee(txtEmployeeCode.Text);
                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                FormClear();
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
