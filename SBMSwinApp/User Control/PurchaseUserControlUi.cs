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
    public partial class PurchaseUserControlUi : UserControl
    {
        public PurchaseUserControlUi()
        {
            InitializeComponent();
        }
        SupplierManager supplierManager = new SupplierManager();
        CategoryManager categoryManager = new CategoryManager();
        ProductManager productManager = new ProductManager();
        PurchaseManager purchaseManager = new PurchaseManager();
        Purchase _purchase;
        List<PurchaseDetails> _purchasesDetails = new List<PurchaseDetails>();

        private void PurchaseUserControlUi_Load(object sender, EventArgs e)
        {
            LoadSupplier();
            LoadCategory();
            ShowPurchase();

        }
        private void LoadSupplier()
        {
            List<Supplier> suppliers = supplierManager.ShowSupplier();
            Supplier supplier = new Supplier();
            supplier.Id = 0;
            supplier.Name = "<--Select-->";
            suppliers.Insert(0, supplier);
            supplierComboBox.DataSource = null;
            supplierComboBox.DataSource = suppliers;
            supplierComboBox.DisplayMember = "Name";
            supplierComboBox.ValueMember = "Id";


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
            reorderLevelTextBox.Text = product.ReorderLevel.ToString();
            if (string.IsNullOrWhiteSpace(codeTextBox.Text))
            {
                availableTextBox.Text = "<View>";
                reorderLevelTextBox.Text = "<View>";
                previousUPTextBox.Text = "<View>";
                previousMRPTextBox.Text = "<View>";

            }
            else
            {
                availableTextBox.Text = purchaseManager.GetAvailableQuantity(Convert.ToInt32(productComboBox.SelectedValue)).ToString();
                int productId =Convert.ToInt32( productComboBox.SelectedValue);
                previousUPTextBox.Text= purchaseManager.GetPreviousUnitPrice(productId).ToString();
                previousMRPTextBox.Text = purchaseManager.GetPreviousMRP(productId).ToString();

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IsProductSectionValid() == true)
            {
                int status = 1;
                var purchaseDetails = new PurchaseDetails();


                foreach (var p in _purchasesDetails)
                {

                    if (p.ProductCode.Contains(codeTextBox.Text))
                    {
                        MessageBox.Show("Product already in list");
                        status = 0;
                    }

                }
                purchaseDetails.ProductID = Convert.ToInt32(productComboBox.SelectedValue);
                purchaseDetails.CategoryID = Convert.ToInt32(categoryComboBox.SelectedValue);

                purchaseDetails.ProductCode = codeTextBox.Text;
                purchaseDetails.ManufactureDate = Convert.ToDateTime(manufactureDateTimePicker.Text);
                purchaseDetails.ExpireDate = Convert.ToDateTime(expiredDateTimePicker.Text);
                purchaseDetails.Quantity = Convert.ToDouble(quantityTextBox.Text);
                purchaseDetails.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
                purchaseDetails.MRP = Convert.ToDouble(MRPTextBox.Text);
                purchaseDetails.Remark = remarkTextBox.Text;
                purchaseDetails.TotalPrice = Convert.ToDouble(totalPriceTextBox.Text);

                if (status == 1)
                {
                    _purchasesDetails.Add(purchaseDetails);
                    displayDataGridView.Rows.Clear();
                    ShowList(_purchasesDetails);
                }
                
                ResetProductSection();
            }
            
        }
        private void ShowList(List<PurchaseDetails> purchaseDetails)
        {
            //displayStatusLabel.Text = "";
            displayDataGridView.DataSource = null;
            //displayDataGridView.DataSource = purchases;
            int SL = 0;
            foreach (var aPurchase in purchaseDetails)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, aPurchase.Id, aPurchase.ProductCode, aPurchase.ManufactureDate, aPurchase.ExpireDate, aPurchase.Quantity, aPurchase.UnitPrice, aPurchase.TotalPrice, aPurchase.MRP, aPurchase.Remark);

            }
            //displayStatusLabel.Text = "Purchase list befor submit";
        }
        private void ShowPurchase()
        {
            //displayStatusLabel.Text = "";
            //var purchases = purchaseManager.ShowPurchase();
            //displayDataGridView.DataSource = null;
            ////displayDataGridView.DataSource = purchases;
            //int SL = 0;
            //foreach (var aPurchase in purchases)
            //{
            //    SL++;
            //    displayDataGridView.Rows.Add(SL, aPurchase.Id, aPurchase.ProductCode, aPurchase.ManufactureDate, aPurchase.ExpireDate, aPurchase.Quantity, aPurchase.UnitPrice, aPurchase.TotalPrice, aPurchase.MRP, aPurchase.Remark);

            //}
            //displayStatusLabel.Text = "All purchased records";
        }
        private double GetTotalPrice(double quantity, double unitprice)
        {
            return quantity * unitprice;
        }
        private double GetMRP(double unitPrice)
        {
            return unitPrice + (unitPrice * 0.25);
        }

        private void QuantityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void UnitPriceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();

            //purchase.Code = DateTime.Today.Year + "-" + codeTextBox.Text;
            purchase.Code = purchaseManager.GetGeneratedPurchaseCode();
            purchase.InvoiceNo = billTextBox.Text;
            purchase.Date = Convert.ToDateTime(purchaseDate.Text);
            purchase.SupplierID = Convert.ToInt32(supplierComboBox.SelectedValue);
            purchaseManager.InsertPurchase(purchase);
            Purchase getId = purchaseManager.GetIdbyInvoiceNo(purchase);
            purchase.Id = getId.Id;


            bool IsInserted = false;
            foreach (var aPurchase in _purchasesDetails)
            {
                IsInserted = purchaseManager.InsertPurchaseDetails(purchase, aPurchase);
            }
            if (IsInserted == true)
            {
                displayDataGridView.Rows.Clear();
            }
            ShowPurchase();
            _purchasesDetails = null;
            MessageBox.Show("Purchase Complete!!!");
            ResetSupplierSection();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //displayDataGridView.Rows.Clear();
            //var purchase = new Purchase();
            //purchase.ProductCode = searchTextBox.Text;
            //purchase.Date =Convert.ToDateTime( searchTextBox.Text);
            ////purchase.Date =Convert.ToDateTime( searchTextBox.Text);
            //var purchases = purchaseManager.SearchPurchase(purchase);
            //ShowList(purchases);
            //displayStatusLabel.Text = "Search Result";
        }

        private void DisplayDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var purchaseDetails = new PurchaseDetails();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayDataGridView.Rows[index];
            purchaseDetails.Id = Convert.ToInt32(selectedRow.Cells[1].Value);
            _purchasesDetails.RemoveAt(purchaseDetails.Id);
            MessageBox.Show("Deleted");
            displayDataGridView.Rows.Clear();
            ShowList(_purchasesDetails);
        }
        private void ResetProductSection()
        {
            categoryComboBox.SelectedValue = 0;
            productComboBox.SelectedValue = 0;
            availableTextBox.Text = "<View>";
            manufactureDateTimePicker.ResetText();
            expiredDateTimePicker.ResetText();
            quantityTextBox.Clear();
            unitPriceTextBox.Clear();
            remarkTextBox.Clear();
            totalPriceTextBox.Text= "<View>";
            previousMRPTextBox.Text = "<View>";
            previousMRPTextBox.Text= "<View>";
            MRPTextBox.Text = "";
        }
        private void ResetSupplierSection()
        {
            purchaseDate.ResetText();
            billTextBox.Clear();
            supplierComboBox.SelectedValue = 0;
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
             
            double unitPrice;
            if (string.IsNullOrWhiteSpace(unitPriceTextBox.Text))
            {
                unitPrice = 0;
            }
            else
            {
                unitPrice = Convert.ToDouble(unitPriceTextBox.Text);
            }

            totalPriceTextBox.Text = GetTotalPrice(quantity, unitPrice).ToString();
        }

        private void UnitPriceTextBox_Leave(object sender, EventArgs e)
        {


            double unitPrice;
            if (string.IsNullOrWhiteSpace(unitPriceTextBox.Text))
            {
                unitPrice = 0;
            }
            else
            {
                unitPrice = Convert.ToDouble(unitPriceTextBox.Text);
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

            totalPriceTextBox.Text = GetTotalPrice(quantity, unitPrice).ToString();
            MRPTextBox.Text = GetMRP(unitPrice).ToString();

            
        }

        private bool IsSupplierSelectioSelected()
        {

            if (String.IsNullOrEmpty(billTextBox.Text))
            {
                MessageBox.Show("Invoice no Filed is empty!!!");
                return false;
            }
            else if (Convert.ToInt32(supplierComboBox.SelectedValue) <= 0)
            {
                MessageBox.Show("Select Supplier First!!!");
                return false;
            }
            else return true;
        }
        private bool IsProductSectionValid()
        {
            if (IsSupplierSelectioSelected()==true)
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
                else if (String.IsNullOrEmpty(quantityTextBox.Text))
                {
                    MessageBox.Show("You must provide quantity!!");
                    return false;
                }
                else if (String.IsNullOrEmpty(unitPriceTextBox.Text))
                {
                    MessageBox.Show("You must provide unite price!!");
                    return false;
                }
                else return true;
            }
            else
            {
                MessageBox.Show("Supplier Section not selected");
                return false;
            }
        }

        
    }
}
