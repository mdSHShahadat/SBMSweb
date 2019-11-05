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
    public partial class PurchaseReportUi : Form
    {
        public PurchaseReportUi()
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

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void NextLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeUi homeUi = new HomeUi();
            homeUi.Show();
            this.Hide();
        }

        private void PreviousLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesReportUi salesReportUi = new SalesReportUi();
            salesReportUi.Show();
            this.Hide();
        }

        private void PurchaseReportUi_Load(object sender, EventArgs e)
        {
           
        }
        private void ShowProfitReportOnPurchase()
        {
            displayDataGridView.Rows.Clear();
            var reports = reportManager.GetAllReport();
            int SL = 0;
            foreach (var aReport in reports)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, aReport.Id, aReport.ProductCode, aReport.ProductName, aReport.CategoryName, aReport.AvailableQuantity, aReport.CostPrice, aReport.MRP, aReport.ProfitOnPurchase);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.Rows.Clear();
            Report report = new Report();
            report.ToDate = Convert.ToDateTime(startDateTimePicker.Text);
            report.FromDate = Convert.ToDateTime(endDateTimePicker.Text);
            var reports = reportManager.GetReportByDateForPurchase(report);
            int SL = 0;
            foreach (var aReport in reports)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, aReport.Id, aReport.ProductCode, aReport.ProductName, aReport.CategoryName, aReport.AvailableQuantity, aReport.CostPrice, aReport.MRP, aReport.ProfitOnPurchase);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowProfitReportOnPurchase();
        }
    }
}
