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
    public partial class HomeUi : Form
    {
        public HomeUi()
        {
            InitializeComponent();
        }

        private void CategoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryUi categoryUi = new CategoryUi();
            categoryUi.Show();
            this.Hide();
        }

        private void ProductLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductUi productUi = new ProductUi();
            productUi.Show();
            this.Hide();

        }

        private void CustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerUi customerUi = new CustomerUi();
            customerUi.Show();
            this.Hide();
        }

        private void SupplierLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierUi supplierUi = new SupplierUi();
            supplierUi.Show();
            this.Hide();
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void HomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PurchaseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseUi purchaseUi = new PurchaseUi();
            purchaseUi.Show();
            this.Hide();
        }

        private void SalesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesUi salesUi = new SalesUi();
            salesUi.Show();
            this.Hide();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockUi stockUi = new StockUi();
            stockUi.Show();
            this.Hide();
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesReportUi salesReportUi = new SalesReportUi();
            salesReportUi.Show();
            this.Hide();
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseReportUi purchaseReportUi = new PurchaseReportUi();
            purchaseReportUi.Show();
            this.Hide();
        }

        private void SalesLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesUi salesUi = new SalesUi();
            salesUi.Show();
            this.Hide();
        }

        private void SearchLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockUi stockUi = new StockUi();
            stockUi.Show();
            this.Hide();
        }

        private void SalesReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesReportUi salesReportUi = new SalesReportUi();
            salesReportUi.Show();
            this.Hide();
        }

        private void PurchaseReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseReportUi purchaseReportUi = new PurchaseReportUi();
            purchaseReportUi.Show();
            this.Hide();
        }
    }
}
