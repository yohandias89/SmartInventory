using SmartInventory.Models;
using SmartInventory.Services;
using System.ComponentModel;

namespace SmartInventory.Forms
{
    public partial class SalesForm : Form
    {
        private BindingList<SalesDetail> salesDetails = new BindingList<SalesDetail>();
        private SalesHeader salesHeader = new SalesHeader();
        public SalesForm()
        {
            InitializeComponent();
            this.Load += SalesForm_Load;
            dgvsalesDetailes.AutoGenerateColumns = false;
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SalesCode",
                HeaderText = "Sales Code",
                Visible = false
            });
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SequenceNo",
                HeaderText = "Sequence No",
            });
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BarcodeNo",
                HeaderText = "Barcode No"
            });
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BatchCode",
                HeaderText = "Batch Code"
            });
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product Name"
            });
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitCode",
                HeaderText = "Unit Code"
            });
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SalesPrice",
                HeaderText = "Sales Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
            });
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SalesQty",
                HeaderText = "Sales Qty",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
            });
            dgvsalesDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SalesAmount",
                HeaderText = "Sales Amount",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
            });


        }

        private void SalesForm_Load(object? sender, EventArgs e)
        {
            var paymentMethods = Enum.GetValues(typeof(PaymentMethod))
                             .Cast<PaymentMethod>()
                             .Select(pm => new
                             {
                                 Value = pm,
                                 Text = pm.ToString()
                             })
                             .ToList();

            cmbPaymentMethod.DataSource = paymentMethods;
            cmbPaymentMethod.DisplayMember = "Text";
            cmbPaymentMethod.ValueMember = "Value";
            cmbPaymentMethod.SelectedIndex = -1;
        }

        private void btnSalesSearch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }

        private void ClearForm()
        {
            txtCustomerCode.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtBarcodeNo.Clear();
            txtBatchCode.Clear();
            txtUnitCode.Clear();
            txtProductName.Clear();
            txtSellingPrice.Clear();
            txtSalesQty.Clear();
            salesDetails.Clear();
            txtTotalPurchase.Text = "0.00";
            dgvsalesDetailes.DataSource = null;
            dgvsalesDetailes.DataSource = salesDetails;
            cmbPaymentMethod.SelectedIndex = -1;
        }
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            CustomerSearchDialog customerSearchDialog = new CustomerSearchDialog();
            if (customerSearchDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedCustomer = customerSearchDialog.SelectedCustomer;
                if (selectedCustomer != null)
                {
                    txtCustomerCode.Text = selectedCustomer.CustomerCode;
                    txtCustomerName.Text = $"{selectedCustomer.FirstName} {selectedCustomer.LastName}";
                    txtAddress.Text = selectedCustomer.Address;
                    txtEmail.Text = selectedCustomer.Email;
                    txtContact.Text = selectedCustomer.Contact;
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                salesHeader.CustomerCode = txtCustomerCode.Text;
                salesHeader.CustomerName = txtCustomerName.Text;
                salesHeader.CustomerAddress = txtAddress.Text;
                salesHeader.CustomerEmail = txtEmail.Text;
                salesHeader.CustomerContact = txtContact.Text;
                salesHeader.PaymentMethod = (PaymentMethod)cmbPaymentMethod.SelectedValue;
                salesHeader.SalesDetails = salesDetails.ToList();

                SalesService.CreateSale(salesHeader);
                MessageBox.Show("Sales record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the sales record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            ProductSearchDialog productSearchDialog = new ProductSearchDialog();
            if (productSearchDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedProduct = productSearchDialog.SelectedProduct;
                if (selectedProduct != null)
                {
                    txtBarcodeNo.Text = selectedProduct.BarcodeNo.ToString();
                    txtBatchCode.Text = selectedProduct.ProductBatch;
                    txtUnitCode.Text = selectedProduct.UnitCode;
                    txtProductName.Text = selectedProduct.ProductName;
                    txtSellingPrice.Text = selectedProduct.SellingPrice.ToString("F2");
                    txtSalesQty.Text = "1.00";
                }
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalesQty.Text, out decimal salesQty) &&
                decimal.TryParse(txtSellingPrice.Text, out decimal sellingPrice))
            {
                salesDetails.Add(new SalesDetail
                {
                    BarcodeNo = int.Parse(txtBarcodeNo.Text),
                    SequenceNo = salesDetails.Count + 1,
                    BatchCode = txtBatchCode.Text,
                    UnitCode = txtUnitCode.Text,
                    ProductName = txtProductName.Text,
                    SalesPrice = sellingPrice,
                    SalesQty = salesQty,
                });

                dgvsalesDetailes.DataSource = null;
                dgvsalesDetailes.DataSource = salesDetails;
                txtTotalPurchase.Text = salesDetails.Sum(sd => sd.SalesAmount).ToString("F2");

                txtBarcodeNo.Clear();
                txtBatchCode.Clear();
                txtUnitCode.Clear();
                txtProductName.Clear();
                txtSellingPrice.Clear();
                txtSalesQty.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid Sales Quantity and Selling Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
