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
    public partial class ProductUi : Form
    {
        public ProductUi()
        {
            InitializeComponent();
            
        }
        CategoryManager categoryManager = new CategoryManager();
        ProductManager productManager = new ProductManager();
        Product _product = new Product();
        List<Product> products = new List<Product>();
        private void HomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeUi homeUi = new HomeUi();
            homeUi.Show();
            this.Close();
        }
        private void ProductUi_Load(object sender, EventArgs e)
        {
            LoadCategories();
            products = productManager.ShowProduct();
            BindProductsListDataGrid(products);
        }
        private void LoadCategories()
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
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (SaveButton.Text == "Save")
                {
                    var product = new Product();
                    product.Code = codeTextBox.Text;
                    product.Name = nameTextBox.Text;
                    product.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                    product.Description = descriptionTextBox.Text;
                    product.CategoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
                    if (productManager.IsProductExist(product) == 1)
                    {
                        MessageBox.Show("Product Code '" + codeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (productManager.IsProductExist(product) == 2)
                    {
                        MessageBox.Show("Product Name '" + nameTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    else
                    {

                        productManager.InsertProduct(product);
                        products = productManager.ShowProduct();
                        BindProductsListDataGrid(products);
                        MessageBox.Show("Saved");
                        ClearTextBox();
                    }
                    

                }
                else if (SaveButton.Text == "Update")
                {
                    int value = Convert.ToInt32(categoryComboBox.SelectedValue);
                    if (value < 1)
                    {
                        MessageBox.Show("Please Select a Category");
                        return ;
                    }

                    {
                        var product = new Product();
                        product.Code = codeTextBox.Text;
                        product.Name = nameTextBox.Text;
                        product.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                        product.Description = descriptionTextBox.Text;
                        product.CategoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
                        _product.Code = product.Code;
                        _product.Name = product.Name;
                        _product.ReorderLevel = product.ReorderLevel;
                        _product.Description = product.Description;
                        _product.CategoryID = product.CategoryID;
                        
                        //if (productManager.IsProductExist(product) == true)
                        //{
                        //    MessageBox.Show("Product Code '" + codeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}else
                        // if (productManager.IsProductExist(product) == true)
                        //{
                        //    MessageBox.Show("Product Name '" + nameTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                        //else
                        //{
                            productManager.UpdateProduct(_product);
                            products = productManager.ShowProduct();
                        MessageBox.Show("Updated");
                        BindProductsListDataGrid(products);
                            ClearTextBox();
                            SaveButton.Text = "Save";

                        //}
                        
                                                                  

                    }
                   
                }
            }
            
            
        }
        private void BindProductsListDataGrid(List<Product>products)
        {
            int SL = 0;
            displayDataGridView.Rows.Clear();
            foreach(var product in products)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, product.Id, product.Code, product.Name, product.CategoryName, product.ReorderLevel, product.Description, product.CategoryID);
            }
        }
        private void DisplayDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayDataGridView.Rows[index];
            _product.Id = Convert.ToInt32(selectedRow.Cells[1].Value);

            codeTextBox.Text = selectedRow.Cells[2].Value.ToString();
            nameTextBox.Text = selectedRow.Cells[3].Value.ToString();
            //categoryComboBox.SelectedItem = selectedRow.Cells[4].Value.ToString();
            reorderLevelTextBox.Text = selectedRow.Cells[5].Value.ToString();
            descriptionTextBox.Text = selectedRow.Cells[6].Value.ToString();

            SaveButton.Text = "Update";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.CategoryName = searchTextBox.Text;
            product.Name = searchTextBox.Text;
            product.Code = searchTextBox.Text;
            products = productManager.SearchProduct(product);
            if (products.Count < 1)
            {
                displayDataGridView.Rows.Clear();
                MessageBox.Show("No record found!!!");

            }
            else
            {
                BindProductsListDataGrid(products);
            }
            
        }
        private bool IsFormValid()
        {
            int value =Convert.ToInt32(categoryComboBox.SelectedValue);
            if (value < 1 )
            {
                MessageBox.Show("Please Select a Category");
                return false;
            }
            if (codeTextBox.Text.ToString().Length != 4)
            {

                MessageBox.Show("Please enter  Code, must be 4 characters in length!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeTextBox.Clear();
                return false;



            }
            else if (nameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter  Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTextBox.Clear();
                return false;
            }

            
            
            //else if (contactTextBox.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Please enter  Contact!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    contactTextBox.Clear();
            //    return false;
            //}


            int x = Convert.ToInt32(reorderLevelTextBox.Text);

            if (x < 10)
            {
                MessageBox.Show("Initial Reorder Level should be 10 or  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reorderLevelTextBox.Clear();
                return false;
            }



            return true;
        }
        public void ClearTextBox()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            reorderLevelTextBox.Clear();
            descriptionTextBox.Clear();
          
        }

        private void PreviousLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryUi categoryUi = new CategoryUi();
            categoryUi.Show();
            this.Hide();
        }

        private void NextLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerUi customerUi = new CustomerUi();
            customerUi.Show();
            this.Hide();
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
