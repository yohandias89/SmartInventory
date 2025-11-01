using SmartInventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartInventory.Forms
{
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void btnSearchPurchases_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

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
                }
            };
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
