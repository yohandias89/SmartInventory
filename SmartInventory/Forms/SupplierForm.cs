using SmartInventory.DataTransferObjects;
using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class SupplierForm : Form
    {
        private List<Supplier> suppliers = [];
        public SupplierForm()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadSuppliers();
            dgvSuppliers.CellDoubleClick += DgvSuppliers_CellDoubleClick;
        }

        private void LoadSuppliers()
        {
            try
            {
                dgvSuppliers.DataSource = null;
                suppliers = SupplierService.GetSuppliers();
                BindingSource bindingSource = new()
                {
                    DataSource = suppliers
                };
                dgvSuppliers.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtSupplierCode.Clear();
            txtSupplierName.Clear();
            txtContactPerson.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void DgvSuppliers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < suppliers.Count)
            {
                Supplier selectedSupplier = suppliers[e.RowIndex];
                if (selectedSupplier == null) {
                    ClearForm();
                    return;
                } 
                txtSupplierCode.Text = selectedSupplier.SupplierCode;
                txtSupplierName.Text = selectedSupplier.SupplierName;
                txtContactPerson.Text = selectedSupplier.ContactPerson;
                txtAddress.Text = selectedSupplier.Address;
                txtEmail.Text = selectedSupplier.Email;
                txtContact.Text = selectedSupplier.Contact;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string supplierCode = SupplierService.GetSupplierCode();
                Supplier newSupplier = new()
                {
                    SupplierCode = supplierCode,
                    SupplierName = txtSupplierName.Text,
                    ContactPerson = txtContactPerson.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Contact = txtContact.Text,
                    CreatedBy = "admin",
                    UpdatedBy = "admin"
                };
                SupplierService.CreateSupplier(newSupplier);
                MessageBox.Show("Supplier saved successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving supplier: " + ex.Message);

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierCode.Text))
            {
                MessageBox.Show("Please select a supplier to update.");
                return;
            }

            try
            {
                SupplierUpdateModel updatedSupplier = new()
                {
                    SupplierCode = txtSupplierCode.Text,
                    SupplierName = txtSupplierName.Text,
                    ContactPerson = txtContactPerson.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Contact = txtContact.Text,
                    UpdatedBy = "admin"
                };
                SupplierService.UpdateSupplier(updatedSupplier);
                MessageBox.Show("Supplier updated successfully.");
                ClearForm();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating supplier: " + ex.Message);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSupplierCode.Text))
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    SupplierService.DeleteSupplier(txtSupplierCode.Text);
                    MessageBox.Show("Supplier deleted successfully.");
                    ClearForm();
                    LoadSuppliers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting supplier: " + ex.Message);
                }
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();

        }
    }
}
