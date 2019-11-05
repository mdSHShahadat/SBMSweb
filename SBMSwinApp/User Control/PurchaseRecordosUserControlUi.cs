using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.Models;
using SBMS.BLL;

namespace SBMS.User_Control
{
    public partial class PurchaseRecordosUserControlUi : UserControl
    {
        public PurchaseRecordosUserControlUi()
        {
            InitializeComponent();
        }
        List<Purchase> purchases = new List<Purchase>();
        PurchaseManager purchaseManager = new PurchaseManager();
        private void BindPurchasesListGridView(List<Purchase> purchases)
        {
            int SL = 0;
            displayPurchaseDataGridView.Rows.Clear();
            foreach (var purchase in purchases)
            {
                SL++;
                displayPurchaseDataGridView.Rows.Add(SL, purchase.Id, purchase.Code, purchase.Date, purchase.InvoiceNo, purchase.SupplierName,purchase.TotalPrice);
            }
        }
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            purchases= purchaseManager.PurchasesShortRecord();
            BindPurchasesListGridView(purchases);
        }
        private void BindPurchasesDetailsRecordListGridView(List<PurchaseDetails> purchaseDetails)
        {
            int No = 0;
            displayPurchaseDetailsDataGridView.Rows.Clear();
            foreach (var purchase in purchaseDetails)
            {
                No++;
                displayPurchaseDetailsDataGridView.Rows.Add(No, purchase.ProductName, purchase.ManufactureDate, purchase.ExpireDate, purchase.Quantity, purchase.UnitPrice, purchase.TotalPrice, purchase.MRP, purchase.Remark);
            }
        }
        private void DisplayPurchaseDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayPurchaseDataGridView.Rows[index];
            int purchaseId =(int) selectedRow.Cells[1].Value;
            List<PurchaseDetails> purchaseDetails = purchaseManager.PurchasesDetailsRecord(purchaseId);
            BindPurchasesDetailsRecordListGridView(purchaseDetails);


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PurchaseRecordosUserControlUi_Load(object sender, EventArgs e)
        {

        }
    }
}
