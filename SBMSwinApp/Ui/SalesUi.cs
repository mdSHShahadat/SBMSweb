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
    public partial class SalesUi : Form
    {
        public SalesUi()
        {
            InitializeComponent();
        }
        CustomerManager customerManager = new CustomerManager();
        CategoryManager categoryManager = new CategoryManager();
        ProductManager productManager = new ProductManager();
        PurchaseManager purchaseManager = new PurchaseManager();
        SalesManager salesManager = new SalesManager();
        Sales _sale = new Sales();
        List<SalesDetails> _salesDetails = new List<SalesDetails>();
        private void HomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeUi homeUi = new HomeUi();
            homeUi.Show();
            this.Hide();
        }

        private void PreviousLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseUi purchaseUi = new PurchaseUi();
            purchaseUi.Show();
            this.Hide();
        }

        private void NextLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockUi stockUi = new StockUi();
            stockUi.Show();
            this.Hide();
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void SalesUi_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadCategory();
        }
        private void LoadCustomer()
        {
            List<Customer> customers = customerManager.ShowCustomer();
            Customer customer = new Customer();
            customer.Id = 0;
            customer.Name = "<--Select-->";
            customers.Insert(0, customer);
            customerComboBox.DataSource = null;
            customerComboBox.DataSource = customers;
            customerComboBox.DisplayMember = "Name";
            customerComboBox.ValueMember = "Id";
            


        }
        private void LoadCategory()
        {
            List<Category> categories = categoryManager.ShowCategory();
            Category category = new Category();
            category.Id = 0;
            category.Name = "<--Select-->";
            categories.Insert(0, category);
            categoryComboBox.DataSource = null;
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
            
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(customerComboBox.SelectedValue);
            var customer = customerManager.GetCustomerById(id);
            loyaltyPointTextBox.Text = customer.LoyaltyPoint.ToString();
           
        }

       
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedValue.ToString() != null)
            {
                int id = Convert.ToInt32(categoryComboBox.SelectedValue);
                List<Product> products = productManager.ShowProductById(id);
                Product product = new Product();
                product.Id = 0;
                product.Name = "<--Select-->";
                products.Insert(0, product);
                productComboBox.DataSource = null;
                productComboBox.DataSource = products;
                productComboBox.DisplayMember = "Name";
                productComboBox.ValueMember = "Id";

            }

        }
        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(productComboBox.SelectedValue);
            Product product = productManager.SearchById(id);
            codeTextBox.Text = product.Code;
           
            if (string.IsNullOrWhiteSpace(codeTextBox.Text))
            {
                availableTextBox.Text = "<View>";
                codeTextBox.Text = "<View>";
                

            }
            else
            {
                availableTextBox.Text = salesManager.GetAvailableQuantity(Convert.ToInt32(productComboBox.SelectedValue)).ToString();
                string purchaseCode = DateTime.Today.Year + "-" + product.Code;
                //Purchase purchase = purchaseManager.LoadLastPurchaseByPurchaseCode(purchaseCode);
                //if (purchase.Code == purchaseCode)
                //{
                //availableTextBox.Text = purchase.Quantity.ToString();
                //previousUPTextBox.Text = purchase.UnitPrice.ToString();
                //previousMRPTextBox.Text = purchase.MRP.ToString();
                //}

            }




        }


        private void QuantityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            double quantity = 1;
            double mrp = 0;
            double availableRecord = Convert.ToDouble(availableTextBox.Text);
            
            if (!string.IsNullOrWhiteSpace(quantityTextBox.Text) && !string.IsNullOrWhiteSpace(MRPTextBox.Text))
            {
                
                 quantity = Convert.ToDouble(quantityTextBox.Text);
                mrp = Convert.ToDouble(MRPTextBox.Text);
                if (availableRecord > quantity )
                {
                    totalPriceTextBox.Text = GetTotal(quantity, mrp).ToString();
                    availableRecord = availableRecord - quantity;
                    availableTextBox.Text = availableRecord.ToString();
                }
                else
                {
                    MessageBox.Show("Product not available;");
                    quantityTextBox.Clear();
                }
                    
            }
            else
            {
                totalPriceTextBox.Text = GetTotal(quantity, mrp).ToString();
            }
            
            
            

        }
        private double GetTotal(double quantity, double mrp)
        {
            return quantity * mrp;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int status = 1;
            var salesDetails = new SalesDetails();
            

            foreach (var s in _salesDetails)
            {
               
                if (s.ProductName.Contains(productComboBox.Text))
                {
                    MessageBox.Show("Product already in list");
                    status = 0;
                }
            }
            
            salesDetails.CustomerID = Convert.ToInt32(customerComboBox.SelectedValue);
            salesDetails.CategoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
            salesDetails.ProductID = Convert.ToInt32(productComboBox.SelectedValue);
            var product = productManager.SearchById(salesDetails.ProductID);
            salesDetails.ProductName = product.Name;
            salesDetails.Quantity = Convert.ToDouble(quantityTextBox.Text);
            salesDetails.MRP = Convert.ToDouble(MRPTextBox.Text);
            salesDetails.TotalMRP = Convert.ToDouble(totalPriceTextBox.Text);
           



            if (status == 1)
            {
                _salesDetails.Add(salesDetails);
                ShowListToGridView(_salesDetails);
                GetLoyaltyPint(_salesDetails);
            }



        }
        private void GetLoyaltyPint(List<SalesDetails> sales)
        {
            double grandTotal = 0;
            double loyalityPoint = 0;
            double discountPersent = 0;
            double discountAmount = 0;
            foreach(var salesDetails in _salesDetails)
            {
                grandTotal = grandTotal +Convert.ToDouble(salesDetails.TotalMRP);
                loyalityPoint = grandTotal / 1000;
                discountPersent = loyalityPoint / 10;
                discountAmount = (grandTotal * (discountPersent / 100));

                
            }
            grandTextBox.Text = grandTotal.ToString("0.00");
            //string.Format("{0:0.####}", number);
            discountTextBox.Text = discountPersent.ToString("0.00");
            discountAmountTextBox.Text = discountAmount.ToString("0.00");
            payableAmountTextBox.Text = (grandTotal - discountAmount).ToString("0.00");

           
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Code = DateTime.Today.Year + "-" + "001";
            sales.CustomerID = Convert.ToInt32(customerComboBox.SelectedValue);
            sales.Date = Convert.ToDateTime(salesDate.Text);
            sales.PaidAmount =Convert.ToDouble(payableAmountTextBox.Text);
            salesManager.InsertSales(sales);
            Sales getId = salesManager.GetIdbyCustomerID(sales);
            sales.Id = getId.Id;


            bool IsInserted = false;
            foreach (var aSales in _salesDetails)
            {
                IsInserted = salesManager.InsertPurchaseDetails(sales, aSales);
            }
            if (IsInserted == true)
            {
                
                MessageBox.Show("Sold");
                displayDataGridView.Rows.Clear();
                _salesDetails.Clear();
            }
           




        }
        private void ShowListToGridView(List<SalesDetails> salesDetails)
        {
            displayDataGridView.Rows.Clear();
            int SL = 1;
            foreach(var sale in salesDetails)
            {
                displayDataGridView.Rows.Add(SL, sale.Id, sale.ProductName, sale.Quantity, sale.MRP, sale.TotalMRP);
                SL++;
            }
        }

        private void DisplayDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var salesDetails = new SalesDetails();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayDataGridView.Rows[index];
            salesDetails.Id = Convert.ToInt32(selectedRow.Cells[1].Value);
            _salesDetails.RemoveAt(salesDetails.Id);
            MessageBox.Show("Deleted");
            displayDataGridView.Rows.Clear();
            ShowListToGridView(_salesDetails);
        }
    }
}
