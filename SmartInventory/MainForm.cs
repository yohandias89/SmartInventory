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
    }
}
