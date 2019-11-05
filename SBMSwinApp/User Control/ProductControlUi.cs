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
    public partial class ProductControlUi : UserControl
    {
        public ProductControlUi()
        {
            InitializeComponent();
        }
        CategoryManager categoryManager = new CategoryManager();
        ProductManager productManager = new ProductManager();
        Product _product = new Product();
        List<Product> products = new List<Product>();
        private void ProductControlUi_Load(object sender, EventArgs e)
        {
            LoadCategories();
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
        private void BindProductsListDataGrid(List<Product> products)
        {
            int SL = 0;
            displayDataGridView.Rows.Clear();
            foreach (var product in products)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, product.Id, product.Code, product.Name, product.CategoryName, product.ReorderLevel, product.Description, product.CategoryID);
            }
        }
        private bool IsFormValid()
        {
            int value = Convert.ToInt32(categoryComboBox.SelectedValue);
            if (value < 1)
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
            }else
            if (String.IsNullOrEmpty(reorderLevelTextBox.Text))
            {
                reorderLevelTextBox.Text = "10";
            }
            else
            {
                int x = Convert.ToInt32(reorderLevelTextBox.Text);

                if (x < 0)
                {
                    MessageBox.Show("Only positive number allowed for Reorder Level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reorderLevelTextBox.Clear();
                    return false;
                }

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
        private void SearchButton_Click_1(object sender, EventArgs e)
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

        private void SaveButton_Click_1(object sender, EventArgs e)
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
                    product.ActionType = "Insert";
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
                        categoryComboBox.SelectedValue = 0;
                    }


                }
                else if (SaveButton.Text == "Update")
                {
                    //int value = Convert.ToInt32(categoryComboBox.SelectedValue);
                    //if (value < 1)
                    //{
                    //    MessageBox.Show("Please Select a Category");
                    //    return;
                    //}

                    
                        var product = new Product();
                        product.Id =Convert.ToInt32(productIdLebel.Text);
                        product.Code = codeTextBox.Text;
                        product.Name = nameTextBox.Text;
                        product.ReorderLevel = Convert.ToInt32(reorderLevelTextBox.Text);
                        product.Description = descriptionTextBox.Text;
                        product.CategoryID = Convert.ToInt32(categoryComboBox.SelectedValue);
                        product.ActionType = "Update";


                        if (productManager.IsProductExist(product) == 1)
                        {
                            MessageBox.Show("Product Code '" + codeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                         if (productManager.IsProductExist(product) == 2)
                        {
                            MessageBox.Show("Product Name '" + nameTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                        productManager.UpdateProduct(product);
                        products = productManager.ShowProduct();
                        MessageBox.Show("Updated");
                        BindProductsListDataGrid(products);
                        ClearTextBox();
                        categoryComboBox.SelectedValue = 0;
                        SaveButton.Text = "Save";

                        }

                }
            }
        }

        private void DisplayDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DisplayDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayDataGridView.Rows[index];
           productIdLebel.Text = Convert.ToString(selectedRow.Cells[1].Value);
            codeTextBox.Text = selectedRow.Cells[2].Value.ToString();
            nameTextBox.Text = selectedRow.Cells[3].Value.ToString();
            categoryComboBox.ResetText();
            categoryComboBox.SelectedText = selectedRow.Cells[4].Value.ToString();
            reorderLevelTextBox.Text = selectedRow.Cells[5].Value.ToString();
            descriptionTextBox.Text = selectedRow.Cells[6].Value.ToString();

            SaveButton.Text = "Update";
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            
            products = productManager.ShowProduct();
            BindProductsListDataGrid(products);

        }
    }
}
