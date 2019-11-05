using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMS.User_Control
{
    public partial class ControlHomeUi : Form
    {
        public ControlHomeUi()
        {
            InitializeComponent();
            HideCommonFile();
            DisplayPanel.Show();
            welcomeLabel.Text = "Welcome, We Will Manage Your Business....";
        }

        private void CategoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Category Setup";
            HideCommonFile();
            categoryContorlUi1.Show();
            
        }

        private void ProductLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Product Entry";
            HideCommonFile();
            productControlUi1.Show();
        }

        private void SupplierLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Supplier Entry";
            HideCommonFile();
            supplieruserControlUi1.Show();
        }

        private void CustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Customer Entry";
            HideCommonFile();
            customerControlUi1.Show();
        }

        private void PurchaseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Purchase Entry";
            HideCommonFile();
            purchaseUserControlUi1.Show();
        }

        private void SalesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Sales Entry";
            HideCommonFile();
            salesUserControlUi1.Show();
        }

        private void SearchLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Stock Details";
            HideCommonFile();
            stockUserControlUi1.Show();
        }

        private void SalesReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Report on Sales";
            HideCommonFile();
            salesReportUserControlUi1.Show();
        }

        private void PurchaseReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Report on Purchase";
            HideCommonFile();
            pruchaseReportUserControlUi1.Show();

        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void HideCommonFile()
        {
           
            categoryContorlUi1.Hide();
            productControlUi1.Hide();
            customerControlUi1.Hide();
            supplieruserControlUi1.Hide();
            stockUserControlUi1.Hide();
            pruchaseReportUserControlUi1.Hide();
            salesReportUserControlUi1.Hide();
            purchaseUserControlUi1.Hide();
            salesUserControlUi1.Hide();
            purchaseRecordosUserControlUi1.Hide();
            salesRecordsUserControlUi1.Hide();


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseViewDetailsLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void PurchaseDetailsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Purchase Details";
            HideCommonFile();
            purchaseRecordosUserControlUi1.Show();
        }

        private void SalesDetailsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controlHeadLabel.Text = "Sales Details";
            HideCommonFile();
            salesRecordsUserControlUi1.Show();
        }
    }
}
