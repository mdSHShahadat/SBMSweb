using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBMS.BLL;
using SBMS.Models;

namespace SBMS.User_Control
{
    public partial class SalesReportUserControlUi : UserControl
    {
        public SalesReportUserControlUi()
        {
            InitializeComponent();
        }

        ReportManager reportManager = new ReportManager();
        List<Report> _reports = new List<Report>();
        private void SearchButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.Rows.Clear();
            Report report = new Report();
            report.ToDate = Convert.ToDateTime(startDateTimePicker.Text);
            report.FromDate = Convert.ToDateTime(endDateTimePicker.Text);
            var reports = reportManager.GetReportByDateForSales(report);
            int SL = 0;
            foreach (var aReport in reports)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, aReport.Id, aReport.ProductCode, aReport.ProductName, aReport.CategoryName, aReport.SoldQuantity, aReport.CostPrice, aReport.SoldPrice, aReport.ProfitOnSales);
            }
        }

        private void ShowProfitReportOnSales()
        {
            displayDataGridView.Rows.Clear();
            var reports = reportManager.GetAllReport();
            int SL = 0;
            foreach (var aReport in reports)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, aReport.Id, aReport.ProductCode, aReport.ProductName, aReport.CategoryName, aReport.SoldQuantity, aReport.CostPrice, aReport.SoldPrice, aReport.ProfitOnSales);
            }
        }



        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            ShowProfitReportOnSales();
        }

        private void SalesReportUserControlUi_Load(object sender, EventArgs e)
        {

        }
    }
}
