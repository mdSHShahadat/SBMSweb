using SBMS.BLL;
using SBMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBMS.Ui
{
    public partial class CustomerUi : Form
    {
        public CustomerUi()
        {
            InitializeComponent();
        }
        Customer _customer = new Customer();
        CustomerManager customerManager = new CustomerManager();
        List<Customer> customers = new List<Customer>();
        private void HomeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomeUi homeUi = new HomeUi();
            homeUi.Show();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (SaveButton.Text == "Save")
                {
                    var customer = new Customer();
                   
                    customer.Code = codeTextBox.Text;
                    customer.Name = nameTextBox.Text;
                    customer.Address = addressTextBox.Text;
                    customer.Email = emailTextBox.Text;
                    customer.Contact = contactTextBox.Text;
                    customer.LoyaltyPoint = Convert.ToInt32(loaltyPointTextBox.Text);
                    if (customerManager.IsCustomerExist(customer) == 1)
                    {
                        MessageBox.Show("Customer Code '" + codeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else if (customerManager.IsCustomerExist(customer) == 2)
                    {
                        MessageBox.Show("Customer Contact '" + contactTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else if (customerManager.IsCustomerExist(customer) == 3)
                    {
                        MessageBox.Show("Customer Email '" + emailTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        customerManager.InsertCustomer(customer);
                        customers = customerManager.ShowCustomer();
                        MessageBox.Show("Saved");
                        BindCustomersListGridView(customers);
                        ClearTextbox();
                    }


                }
                else if (SaveButton.Text == "Update")
                {
                    if (IsFormValid())
                    {
                        var customer = new Customer();
                    customer.Code = codeTextBox.Text;
                    customer.Name = nameTextBox.Text;
                    customer.Address = addressTextBox.Text;
                    customer.Email = emailTextBox.Text;
                    customer.Contact = contactTextBox.Text;
                    customer.LoyaltyPoint = Convert.ToInt32(loaltyPointTextBox.Text);
                    _customer.Code = customer.Code;
                    _customer.Name= customer.Name;
                    _customer.Address = customer.Address;
                    _customer.Email = customer.Email;
                    _customer.Contact = customer.Contact;
                    _customer.LoyaltyPoint = customer.LoyaltyPoint;
                   
                        customerManager.UpdateCustomer(_customer);
                        customers = customerManager.ShowCustomer();
                        BindCustomersListGridView(customers);
                        ClearTextbox();
                        SaveButton.Text = "Save";
                        MessageBox.Show("Updated");
                    }
                    
                }
            }
            

        }
        private void BindCustomersListGridView(List<Customer> customers)
        {
            int SL = 0;
            displayDataGridView.Rows.Clear();
            foreach (var customer in customers)
            {
                SL++;
                displayDataGridView.Rows.Add(SL,customer.Id, customer.Code, customer.Name, customer.Address, customer.Email, customer.Contact, customer.LoyaltyPoint);
            }
            
        }

        private void CustomerUi_Load(object sender, EventArgs e)
        {
            customers = customerManager.ShowCustomer();
            BindCustomersListGridView(customers);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.Contact = searchTextBox.Text;
            customer.Name = searchTextBox.Text;
            customer.Email = searchTextBox.Text;
            customers = customerManager.SearchCustomer(customer);
            if(customers.Count < 1)
            {
                displayDataGridView.Rows.Clear();
                MessageBox.Show(" No record Found!!!");
                
            }
            else
            {
                BindCustomersListGridView(customers);
            }
            
        }

        private void ContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                // is a digit or backspace - ignore digits if length is alreay 10 - allow backspace
                if (Char.IsDigit(e.KeyChar))
                {
                    if (contactTextBox.Text.Length == 11)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void ClearTextbox()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            loaltyPointTextBox.Clear();
            
        }
        private bool IsFormValid()
        {
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

            else if (!string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                Regex reg = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (!reg.IsMatch(emailTextBox.Text))
                {
                    MessageBox.Show("Please enter valid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (contactTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter  Contact!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contactTextBox.Clear();
                return false;
            }
           
            
                int x = Convert.ToInt32(loaltyPointTextBox.Text);

                if (x < 0)
                {
                    MessageBox.Show("Initial Loyalty Point should be 0 or  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contactTextBox.Clear();
                    return false;
                }
          
            

            return true;
        }

        private void DisplayDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayDataGridView.Rows[index];
            _customer.Id = Convert.ToInt32(selectedRow.Cells[1].Value);

            codeTextBox.Text = selectedRow.Cells[2].Value.ToString();
            nameTextBox.Text = selectedRow.Cells[3].Value.ToString();
            addressTextBox.Text = selectedRow.Cells[4].Value.ToString();
            emailTextBox.Text = selectedRow.Cells[5].Value.ToString();
            contactTextBox.Text = selectedRow.Cells[6].Value.ToString();
            loaltyPointTextBox.Text = selectedRow.Cells[7].Value.ToString();
            SaveButton.Text = "Update";
        }

        private void NextLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierUi supplierUi = new SupplierUi();
            supplierUi.Show();
            this.Hide();
        }

        private void PreviousLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductUi productUi = new ProductUi();
            productUi.Show();
            this.Hide();
        }
    }
}
