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
    public partial class CategoryContorlUi : UserControl
    {
        public CategoryContorlUi()
        {
            InitializeComponent();
        }
        Category _category = new Category();
        List<Category> categories = new List<Category>();
        CategoryManager categoryManager = new CategoryManager();

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var category = new Category();
            category.Code = searchTextBox.Text;
            category.Name = searchTextBox.Text;
            categories = categoryManager.SearchCategory(category);
            if (categories.Count < 1)
            {
                displayDataGridView.Rows.Clear();
                MessageBox.Show("No record found!!!");

            }
            else
            {
                BindCategoriesListGridView(categories);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (SaveButton.Text == "Save")
                {
                    var category = new Category();
                    category.Code = categoryCodeTextBox.Text;
                    category.Name = categoryNameTextBox.Text;
                    category.ActionType = "Insert";
                    if (categoryManager.IsCategoryExist(category) == 1)
                    {
                        MessageBox.Show("Category Code '" + categoryCodeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        categoryCodeTextBox.Clear();
                        return;
                    }
                    else if (categoryManager.IsCategoryExist(category) == 2)
                    {
                        MessageBox.Show("Category Name '" + categoryNameTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        categoryNameTextBox.Clear();
                        return;
                    }
                    else
                    {
                        categoryManager.InsertCategory(category);
                        categories = categoryManager.ShowCategory();
                        BindCategoriesListGridView(categories);
                        categoryCodeTextBox.Clear();
                        categoryNameTextBox.Clear();
                        MessageBox.Show("Saved");
                    }

                }
                else if (SaveButton.Text == "Update")
                {
                    var category = new Category();
                    category.Id = Convert.ToInt32(idLabel.Text);
                    category.Code = categoryCodeTextBox.Text;
                    category.Name = categoryNameTextBox.Text;
                    category.ActionType = "Update";
                    if (categoryManager.IsCategoryExist(category) == 1)
                    {
                        MessageBox.Show("Category Code '" + categoryCodeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        categoryCodeTextBox.Clear();
                        return;
                    }
                    else if (categoryManager.IsCategoryExist(category) == 2)
                    {
                        MessageBox.Show("Category Name '" + categoryNameTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        categoryNameTextBox.Clear();
                        return;
                    }
                    else
                    {
                        categoryManager.UpdateCategory(category);
                        categories = categoryManager.ShowCategory();
                        BindCategoriesListGridView(categories);
                        categoryCodeTextBox.Clear();
                        categoryNameTextBox.Clear();
                        MessageBox.Show("Updated");
                        SaveButton.Text = "Save";

                    }


                }
            }
        }

        private void CategoryContorlUi_Load(object sender, EventArgs e)
        {
           
        }
        private bool IsFormValid()
        {
            if (categoryCodeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter category Code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categoryCodeTextBox.Clear();
                return false;
            }
            else if (categoryNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter category Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categoryCodeTextBox.Clear();
                return false;
            }
            else if (categoryCodeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code must be 4 characters in length!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categoryCodeTextBox.Clear();
                return false;
            }
            return true;
        }
        private void BindCategoriesListGridView(List<Category> categories)
        {
            int SL = 0;
            displayDataGridView.Rows.Clear();
            foreach (var category in categories)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, category.Id, category.Code, category.Name);
            }
        }
        private void DisplayDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var category = new Category();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayDataGridView.Rows[index];
            idLabel.Text = selectedRow.Cells[1].Value.ToString();
            categoryCodeTextBox.Text = selectedRow.Cells[2].Value.ToString();
            categoryNameTextBox.Text = selectedRow.Cells[3].Value.ToString();
            SaveButton.Text = "Update";
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            categories = categoryManager.ShowCategory();
            BindCategoriesListGridView(categories);
        }
    }
}
