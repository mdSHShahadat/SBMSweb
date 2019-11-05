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
    public partial class SalesRecordsUserControlUi : UserControl
    {
        public SalesRecordsUserControlUi()
        {
            InitializeComponent();
        }

        SalesManager salesManager = new SalesManager();
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            var sales = salesManager.SalesShortRecord();
            BindPurchasesListGridView(sales);
        }
        private void BindPurchasesListGridView(List<Sales> sales)
        {
            int SL = 0;
            displaySalesDataGridView.Rows.Clear();
            foreach (var sale in sales)
            {
                SL++;
                displaySalesDataGridView.Rows.Add(SL, sale.Id, sale.Code, sale.Date.ToShortDateString(),  sale.CustomerName, sale.PaidAmount);

            }
        }

        private void DisplaySalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = displaySalesDataGridView.Rows[index];
            int salesId = (int)selectedRow.Cells[1].Value;
            var salesDetails = salesManager.PurchasesDetailsRecord(salesId);
            BindSalesDetailsRecordListGridView(salesDetails);
        }
        private void BindSalesDetailsRecordListGridView(List<SalesDetails> salesDetails)
        {
            int No = 0;
            displaySalesDetailsDataGridView.Rows.Clear();
            foreach (var salesDetail in salesDetails)
            {
                No++;
                displaySalesDetailsDataGridView.Rows.Add(No, salesDetail.ProductName, salesDetail.CategoryName, salesDetail.Quantity, salesDetail.MRP, salesDetail.TotalMRP);
            }
        }

        private void SalesRecordsUserControlUi_Load(object sender, EventArgs e)
        {

        }
    }
}
