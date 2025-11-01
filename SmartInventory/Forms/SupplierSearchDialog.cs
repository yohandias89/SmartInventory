using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class SupplierSearchDialog : Form
    {
        private List<SupplierSearchModel> searchModels = new();
        public SupplierSearchModel SelectedSupplier { get; private set; }
        private BindingSource bindingSource = new();
        private int pageSize = 10;
        private int currentPage = 1;
        private int totalRecords = 0;
        private int totalPages = 0;
        private string filterSupplierName = "";
        private string filterEmail = "";
        private string filterContact = "";
        public SupplierSearchDialog()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ProductSearchDialog_Load);
            dgvSearchedSuppliers.CellDoubleClick += DgvSearchedSuppliers_CellDoubleClick;
        }

        private void DgvSearchedSuppliers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < searchModels.Count)
            {
                SelectedSupplier = searchModels[e.RowIndex];
                if (SelectedSupplier != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                 
            }
        }

        private void ProductSearchDialog_Load(object? sender, EventArgs e)
        {
            LoadPage(1);
        }

        private void LoadPage(int pageNumber)
        {
            searchModels = SupplierService.GetSupplierSearchDetails(
                out totalRecords,
                out totalPages,
                pageSize,
                currentPage,
                filterSupplierName,
                filterEmail,
                filterContact);

            dgvSearchedSuppliers.DataSource = null;
            bindingSource.DataSource = searchModels;
            dgvSearchedSuppliers.DataSource = bindingSource;
            txtPageInfo.Text = $"Page {currentPage} of {totalPages}";
        }

        private void ApplySupplierFilter()
        {
            filterSupplierName = txtSupplierName.Text.Trim();
            filterEmail = txtEmail.Text.Trim();
            filterContact = txtContact.Text.Trim();
            currentPage = 1;
            LoadPage(currentPage);

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ApplySupplierFilter();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage(currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage(currentPage);
            }

        }
    }
}
