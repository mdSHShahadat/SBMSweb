using SBMS.BLL;
using SBMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMS.Ui
{
    public partial class SalesReportUi : Form
    {
        public SalesReportUi()
        {
            InitializeComponent();
        }
        ReportManager reportManager = new ReportManager();
        List<Report> _reports = new List<Report>();
        private void HomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeUi homeUi = new HomeUi();
            homeUi.Show();
            this.Hide();
        }

        private void PreviousLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockUi stockUi = new StockUi();
            stockUi.Show();
            this.Hide();
        }

        private void NextLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseReportUi purchaseReportUi = new PurchaseReportUi();
            purchaseReportUi.Show();
            this.Hide();
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void SalesReportUi_Load(object sender, EventArgs e)
        {
            
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

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowProfitReportOnSales();
        }
    }
}
