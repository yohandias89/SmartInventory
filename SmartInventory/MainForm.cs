using SmartInventory.Forms;

namespace SmartInventory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.MdiParent = this;
            categoryForm.Show();

        }

        private void SubCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubcategoryForm subcategoryForm = new SubcategoryForm();
            subcategoryForm.MdiParent = this;
            subcategoryForm.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = this;
            customerForm.Show();

        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.MdiParent = this;
            employeeForm.Show();
        }

        private void SupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.MdiParent = this;
            supplierForm.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.MdiParent = this;
            purchaseForm.Show();
        }
    }
}
