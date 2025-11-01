using SmartInventory.Models;
using SmartInventory.Services;

namespace SmartInventory.Forms
{
    public partial class CustomerSearchDialog : Form
    {
        private List<CustomerSearchModel> searchModels = new();
        public CustomerSearchModel SelectedCustomer { get; private set; }
        private BindingSource bindingSource = new();

        private int pageSize = 10;
        private int currentPage = 1;
        private int totalRecords = 0;
        private int totalPages = 0;
        private string filterFirstName = "";
        private string filterLastName = "";
        private string filterNIC = "";
        private string filterEmail = "";
        private string filterContact = "";
        public CustomerSearchDialog()
        {
            InitializeComponent();
            this.Load += CustomerSearchDialog_Load;
            dgvSearchedCustomers.CellDoubleClick += DgvSearchedCustomers_CellDoubleClick;
        }

        private void DgvSearchedCustomers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex >= 0 && e.RowIndex < searchModels.Count)
            {
                SelectedCustomer = searchModels[e.RowIndex];
                if (SelectedCustomer != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void CustomerSearchDialog_Load(object? sender, EventArgs e)
        {
            LoadPage(1);
        }

        private void ApplyFilters()
        {
            filterFirstName = txtFirstName.Text.Trim();
            filterLastName = txtLastName.Text.Trim();
            filterNIC = txtNIC.Text.Trim();
            filterEmail = txtEmail.Text.Trim();
            filterContact = txtContact.Text.Trim();
            currentPage = 1;
            LoadPage(currentPage);
        }

        private void LoadPage(int pageNumber)
        {
            searchModels = CustomerService.GetCustomerSearchDetails(
                out totalRecords,
                out totalPages,
                pageSize,
                currentPage,
                filterFirstName,
                filterLastName,
                filterNIC,
                filterEmail,
                filterContact);
            bindingSource.DataSource = searchModels;
            dgvSearchedCustomers.DataSource = bindingSource;
            currentPage = pageNumber;
            txtPageInfo.Text = $"Page {currentPage} of {totalPages}";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();

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
