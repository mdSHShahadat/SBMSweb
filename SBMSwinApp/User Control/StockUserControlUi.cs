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
    public partial class StockUserControlUi : UserControl
    {
        public StockUserControlUi()
        {
            InitializeComponent();
        }
        Stock _stock = new Stock();
        StockManager stockManager = new StockManager();
        List<Stock> _stocks = new List<Stock>();
        ProductManager productManager = new ProductManager();

        private void ShowSearchResult(List<Stock> stocks)
        {
            int SL = 0;
            displayDataGridView.Rows.Clear();
            foreach (var aStock in stocks)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, aStock.Id, aStock.ProductCode, aStock.ProductName, aStock.CategoryName, aStock.Reorderlevel, aStock.OpeningBalance, aStock.In, aStock.Out, aStock.ClosingBalance);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(categoryTextBox.Text) && !String.IsNullOrEmpty(productTextBox.Text))
            {
                var stocks = new List<Stock>();
                var stock = new Stock();
                var product = new Product();

                stock.ProductName = productTextBox.Text;
                stock.CategoryName = categoryTextBox.Text;
                stock.StartDate = Convert.ToDateTime(startDateTimePicker.Text);
                stock.EndDate = Convert.ToDateTime(endDateTimePicker.Text);
                stock.OpeningBalance = Convert.ToInt32(stockManager.GetOpeningBalance(stock));
                stock.In = Convert.ToInt32(stockManager.GetInBalance(stock));
                stock.Out = Convert.ToInt32(stockManager.GetOutBalance(stock));
                stock.ClosingBalance = Convert.ToInt32(stockManager.GetAvailableBalance(stock));
                product.Name = stock.ProductName;
                var products = productManager.SearchProduct(product);
                foreach (var aProduct in products)
                {
                    stock.ProductCode = aProduct.Code;
                    stock.CategoryName = aProduct.CategoryName;
                    stock.Reorderlevel = aProduct.ReorderLevel;
                }
                stocks.Add(stock);
                displayDataGridView.Rows.Clear();
                ShowSearchResult(stocks);
            }
            else if (!String.IsNullOrEmpty(categoryTextBox.Text) && String.IsNullOrEmpty(productTextBox.Text))
            {

                var stocks = new List<Stock>();
                var productsList = stockManager.GetPurchasedProductNameList(categoryTextBox.Text.ToString());
                foreach (var productName in productsList)
                {
                    var stock = new Stock();
                    var stock1 = new Stock();
                    stock1.ProductName = productName.Name;
                    stock1.StartDate = Convert.ToDateTime(startDateTimePicker.Text);
                    stock1.EndDate = Convert.ToDateTime(endDateTimePicker.Text);
                    stock.OpeningBalance = Convert.ToInt32(stockManager.GetOpeningBalance(stock1));
                    stock.In = Convert.ToInt32(stockManager.GetInBalance(stock1));
                    stock.Out = Convert.ToInt32(stockManager.GetOutBalance(stock1));
                    stock.ClosingBalance = Convert.ToInt32(stockManager.GetAvailableBalance(stock1));
                    stock.ProductCode = productName.Code;
                    stock.Reorderlevel = productName.ReorderLevel;
                    stock.ProductName = stock1.ProductName;
                    stock.CategoryName = categoryTextBox.Text.ToString();
                    stocks.Add(stock);
                }
                displayDataGridView.Rows.Clear();
                ShowSearchResult(stocks);
            }
            else
            {
                if (String.IsNullOrEmpty(productTextBox.Text) && String.IsNullOrEmpty(categoryTextBox.Text))
                {
                    MessageBox.Show("Both field are empty, Please give Product or Category name!!");
                }
                if (!String.IsNullOrEmpty(productTextBox.Text) && !String.IsNullOrEmpty(categoryTextBox.Text))
                {
                    MessageBox.Show("Please give one input (Product name or Category name) at a time!!");
                }
            }
        }

        private void StockUserControlUi_Load(object sender, EventArgs e)
        {

        }
    }
}
