using SmartInventory.Forms;
using SmartInventory.Forms.CustomerForms;

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
            CustomerList customerList = new CustomerList();
            customerList.MdiParent = this;
            customerList.Show();


        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList();
            employeeList.MdiParent = this;
            employeeList.Show();
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

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.MdiParent = this;
            salesForm.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            productListForm.MdiParent = this;
            productListForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
