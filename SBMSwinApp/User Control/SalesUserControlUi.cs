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
    public partial class SalesUserControlUi : UserControl
    {
        public SalesUserControlUi()
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
        Customer customer = new Customer();


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
        private double GetTotal(double quantity, double mrp)
        {
            return quantity * mrp;
        }
        private void GetLoyaltyPint(List<SalesDetails> sales)
        {
           
            double loyalityPoint = 0;
            if (String.IsNullOrEmpty(loyaltyPointTextBox.Text))
            {
                loyalityPoint = 0;
            }else
            {
                loyalityPoint = Convert.ToDouble(loyaltyPointTextBox.Text); //taking existing loyalty point
            }
            int discountPersent = 0;
            double discountAmount = 0;
            double grandTotal = 0;
            foreach (var salesDetails in _salesDetails)
            {
                grandTotal = grandTotal + Convert.ToDouble(salesDetails.TotalMRP);
            }
            grandTextBox.Text = grandTotal.ToString("0.00");
            if (grandTotal >= 1000)
            {
                if (loyalityPoint >= 10)
                {
                    discountPersent = (int)(loyalityPoint / 10);// calculate discount persentage

                    //decimal discount = (discountPersent / 100);
                    discountAmount = (grandTotal * discountPersent)/100;//calculate discout amount
                }
                else
                {
                    discountPersent = 0;
                   

                }
                double newLoyaltyPoint = grandTotal / 1000;
                
                loyalityPoint = (loyalityPoint+ newLoyaltyPoint) - discountPersent;//reset loyalty point
                //string.Format("{0:0.####}", number);
                discountTextBox.Text = discountPersent.ToString("0.00");
                discountAmountTextBox.Text = discountAmount.ToString("0.00");
                payableAmountTextBox.Text = (grandTotal - discountAmount).ToString("0.00");
                customer.LoyaltyPoint = loyalityPoint; // passing updateable point to next
            }
            else
            {
                discountPersent =(int)( loyalityPoint / 10);
                discountAmount = (grandTotal * discountPersent) / 100;
                loyalityPoint = loyalityPoint - discountPersent;//reset loyalty point
                //string.Format("{0:0.####}", number);
                discountTextBox.Text = discountPersent.ToString("0.00");
                discountAmountTextBox.Text = discountAmount.ToString("0.00");
                payableAmountTextBox.Text = (grandTotal - discountAmount).ToString("0.00");
                customer.LoyaltyPoint = loyalityPoint; // passing updateable point to next
            }
            


        }
        private void ShowListToGridView(List<SalesDetails> salesDetails)
        {
            displayDataGridView.Rows.Clear();
            int SL = 1;
            foreach (var sale in salesDetails)
            {
                displayDataGridView.Rows.Add(SL, sale.Id, sale.ProductName, sale.Quantity, sale.MRP, sale.TotalMRP);
                SL++;
            }
        }
        private void SalesUserControlUi_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadCategory();
        }
        private void CustomerComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(customerComboBox.SelectedValue);
            var customer = customerManager.GetCustomerById(id);
            loyaltyPointTextBox.Text = customer.LoyaltyPoint.ToString();
        }
        private void CategoryComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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
               
                MRPTextBox.Text = purchaseManager.GetPreviousMRP(Convert.ToInt32(productComboBox.SelectedValue)).ToString();


            }
        }
        private void QuantityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            

        }
        private void AddButton_Click(object sender, EventArgs e)
        {

           if(IsProductSectionValid() == true)
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
                ResetProductSection();
            }
            
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Code = salesManager.GetGeneratedSalesCode();
            sales.CustomerID = Convert.ToInt32(customerComboBox.SelectedValue);
            sales.Date = Convert.ToDateTime(salesDate.Text);
            sales.PaidAmount = Convert.ToDouble(payableAmountTextBox.Text);
            salesManager.InsertSales(sales);
            Sales getId = salesManager.GetIdbyCustomerID(sales);
            sales.Id = getId.Id;

            customer.Id = Convert.ToInt32(customerComboBox.SelectedValue);
            bool IsInserted = false;
            foreach (var aSales in _salesDetails)
            {
                IsInserted = salesManager.InsertPurchaseDetails(sales, aSales);
            }
            if (IsInserted == true)
            {

                MessageBox.Show("Sold");
                displayDataGridView.Rows.Clear();
                UpdateCustomerLoyaltyPoint();
                _salesDetails.Clear();
                ResetCustomerSection();
                ResetPurchaseDetais();
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

        private void QuantityTextBox_Leave(object sender, EventArgs e)
        {

            double quantity;
            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                quantity = 0;
            }
            else
            {
                quantity = Convert.ToDouble(quantityTextBox.Text);
            }

            double mrp;
            if (string.IsNullOrWhiteSpace(MRPTextBox.Text))
            {
                mrp = 0;
            }
            else
            {
                mrp = Convert.ToDouble(MRPTextBox.Text);
            }
            availableTextBox.Text = (Convert.ToDouble(availableTextBox.Text)- quantity).ToString();
            totalPriceTextBox.Text =(quantity* mrp).ToString();

            //double quantity = 1;
            //double mrp = 0;
            //double availableRecord = Convert.ToDouble(availableTextBox.Text);

            //if (!string.IsNullOrWhiteSpace(quantityTextBox.Text) && !string.IsNullOrWhiteSpace(MRPTextBox.Text))
            //{

            //    quantity = Convert.ToDouble(quantityTextBox.Text);
            //    mrp = Convert.ToDouble(MRPTextBox.Text);
            //    if (availableRecord > quantity)
            //    {
            //        totalPriceTextBox.Text = GetTotal(quantity, mrp).ToString();
            //        availableRecord = availableRecord - quantity;
            //        availableTextBox.Text = availableRecord.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Product not available;");
            //        quantityTextBox.Clear();
            //    }

            //}
            //else
            //{
            //    totalPriceTextBox.Text = GetTotal(quantity, mrp).ToString();
            //}

        }

        private void MRPTextBox_Leave(object sender, EventArgs e)
        {
            double mrp;
            if (string.IsNullOrWhiteSpace(MRPTextBox.Text))
            {
                mrp = 0;
            }
            else
            {
                mrp = Convert.ToDouble(MRPTextBox.Text);
            }

            double quantity;
            if (string.IsNullOrWhiteSpace(quantityTextBox.Text))
            {
                quantity = 0;
            }
            else
            {
                quantity = Convert.ToDouble(quantityTextBox.Text);
            }

            totalPriceTextBox.Text = (quantity* mrp).ToString();
        }
        private void ResetProductSection()
        {
            categoryComboBox.SelectedValue = 0;
            productComboBox.SelectedValue = 0;
            availableTextBox.Text = "<View>";
            quantityTextBox.Clear();
            MRPTextBox.Clear();
            totalPriceTextBox.Text= "<View>";
        }
        private void ResetCustomerSection()
        {
            customerComboBox.SelectedValue = 0;
            salesDate.ResetText();
            loyaltyPointTextBox.Text = "<View>";
        }
        private void ResetPurchaseDetais()
        {
            grandTextBox.Clear();
            discountTextBox.Clear();
            discountAmountTextBox.Clear();
            payableAmountTextBox.Clear();
        }
        private void UpdateCustomerLoyaltyPoint()
        {
            Customer aCustomer = new Customer();
            aCustomer.Id = customer.Id;
            aCustomer.LoyaltyPoint = customer.LoyaltyPoint;
            customerManager.UpdateCustomerLoyaltyPoint(aCustomer);
        }

        private bool IsCustomerSelectioSelected()
        {

            if (Convert.ToInt32(customerComboBox.SelectedValue) <= 0)
            {
                MessageBox.Show("Select Customer First!!!");
                return false;
            }
            else return true;
        }
        private bool IsProductSectionValid()
        {
            if (IsCustomerSelectioSelected() == true)
            {
                if (Convert.ToInt32(categoryComboBox.SelectedValue) <= 0)
                {
                    MessageBox.Show("Select Category!!");
                    return false;
                }
                else if (Convert.ToInt32(productComboBox.SelectedValue) <= 0)
                {
                    MessageBox.Show("Select Product!!");
                    return false;
                }
                else if (Convert.ToInt32(availableTextBox.Text) <= 0)
                {
                    MessageBox.Show("Sorry, this product is not available now");
                    return false;
                }
                else if (String.IsNullOrEmpty(quantityTextBox.Text))
                {
                    MessageBox.Show("You must provide quantity!!");
                    return false;
                }
                else if (String.IsNullOrEmpty(MRPTextBox.Text))
                {
                    MessageBox.Show("You must provide MRP!!");
                    return false;
                }
                else return true;
            }
            else
            {
                MessageBox.Show("Customer Section not selected");
                return false;
            }
        }
    }
}
