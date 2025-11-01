using SmartInventory.Models;
using SmartInventory.Services;
using System.ComponentModel;


namespace SmartInventory.Forms
{
    public partial class PurchaseForm : Form
    {
        private BindingList<PurchaseDetail> purchaseDetails = new BindingList<PurchaseDetail>();
        private PurchaseHeader purchaseHeader = new PurchaseHeader();
        public PurchaseForm()
        {
            InitializeComponent();
            Load += PurchaseForm_Load;
            dgvPurchaseDetailes.AutoGenerateColumns = false;
            dgvPurchaseDetailes.DataSource = purchaseDetails;
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PurchaseCode",
                HeaderText = "Purchase Code",
                Visible = false
            });
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SequenceNo",
                HeaderText = "Sequence No",
            });
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BarcodeNo",
                HeaderText = "Barcode No"
            });
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BatchCode",
                HeaderText = "Batch Code"
            });
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Product Name"
            });
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UintCode",
                HeaderText = "Unit Code"
            });
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PurchasePrice",
                HeaderText = "Purchase Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
            });
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PurchaseQty",
                HeaderText = "Purchase Qty",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
            });
            dgvPurchaseDetailes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PurchaseAmount",
                HeaderText = "Purchase Amount",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "F2" }
            });
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
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

        private void btnSearchPurchases_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            SupplierSearchDialog supplierSearchDialog = new SupplierSearchDialog();
            if (supplierSearchDialog.ShowDialog() == DialogResult.OK)
            {
                SupplierSearchModel selected = supplierSearchDialog.SelectedSupplier;
                if (selected != null)
                {
                    txtSupplierCode.Text = selected.SupplierCode.ToString();
                    txtSupplierName.Text = selected.SupplierName.ToString();
                    txtAddress.Text = selected.Address.ToString();
                }
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                purchaseHeader.SupplierCode = txtSupplierCode.Text;
                purchaseHeader.SupplierName = txtSupplierName.Text;
                purchaseHeader.SupplierAddress = txtAddress.Text;
                purchaseHeader.Remarks = txtRemarks.Text;
                purchaseHeader.PaymentMethod = (PaymentMethod)cmbPaymentMethod.SelectedValue;
                purchaseHeader.PurchaseDetails = purchaseDetails.ToList();

                PurchaseService.CreatePurchase(purchaseHeader);
                ClearForm();
                MessageBox.Show("Purchase saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving purchase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearForm()
        {
            txtSupplierCode.Clear();
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtRemarks.Clear();
            cmbPaymentMethod.SelectedIndex = -1;
            purchaseDetails.Clear();
            txtTotalPurchase.Text = "0.00";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

        private void BtnProductSearch_Click(object sender, EventArgs e)
        {
            ProductSearchDialog productSearchDialog = new ProductSearchDialog();
            if (productSearchDialog.ShowDialog() == DialogResult.OK)
            {
                ProductSearchModel selected  = productSearchDialog.SelectedProduct;
                if (selected != null)
                {  
                    txtBarcodeNo.Text = selected.BarcodeNo.ToString();
                    txtBatchCode.Text = selected.ProductBatch.ToString();
                    txtProductName.Text = selected.ProductName.ToString();
                    txtUnitCode.Text = selected.UnitCode.ToString();
                    txtPurchasePrice.Text = selected.CostPrice.ToString("F2");
                    txtPurchaseQty.Text = "1.00";
                }
            };
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            PurchaseDetail detail = new PurchaseDetail
            {
                SequenceNo = purchaseDetails.Count + 1,
                BarcodeNo = int.Parse(txtBarcodeNo.Text),
                BatchCode = txtBatchCode.Text,
                ProductName = txtProductName.Text,
                UintCode = txtUnitCode.Text,
                PurchasePrice = decimal.Parse(txtPurchasePrice.Text),
                PurchaseQty = decimal.Parse(txtPurchaseQty.Text)
            };
            purchaseDetails.Add(detail);
            dgvPurchaseDetailes.DataSource = null;
            dgvPurchaseDetailes.DataSource = purchaseDetails;

            txtTotalPurchase.Text = purchaseDetails.Sum(pd => pd.PurchaseAmount).ToString("F2");
            // Clear product input fields
            txtBarcodeNo.Clear();
            txtBatchCode.Clear();
            txtProductName.Clear();
            txtUnitCode.Clear();
            txtPurchasePrice.Clear();
            txtPurchaseQty.Clear();

        }
    }
}
