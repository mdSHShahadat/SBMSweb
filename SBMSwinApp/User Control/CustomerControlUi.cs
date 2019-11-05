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
using System.Text.RegularExpressions;

namespace SBMS.User_Control
{
    public partial class CustomerControlUi : UserControl
    {
        public CustomerControlUi()
        {
            InitializeComponent();
        }
        Customer _customer = new Customer();
        CustomerManager customerManager = new CustomerManager();
        List<Customer> customers = new List<Customer>();

        private void CustomerControlUi_Load(object sender, EventArgs e)
        {
            
        }

        

        private void BindCustomersListGridView(List<Customer> customers)
        {
            int SL = 0;
            displayDataGridView.Rows.Clear();
            foreach (var customer in customers)
            {
                SL++;
                displayDataGridView.Rows.Add(SL, customer.Id, customer.Code, customer.Name, customer.Address, customer.Email, customer.Contact, customer.LoyaltyPoint);
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
            }else if (String.IsNullOrEmpty(loaltyPointTextBox.Text))
            {
                loaltyPointTextBox.Text = "0";
            }
            else
            {
                int x = Convert.ToInt32(loaltyPointTextBox.Text);

                if (x < 0)
                {
                    MessageBox.Show("Initial Loyalty Point should be 0 or  greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contactTextBox.Clear();
                    return false;
                }
            }
            return true;
        }
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.Contact = searchTextBox.Text;
            customer.Name = searchTextBox.Text;
            customer.Email = searchTextBox.Text;
            customers = customerManager.SearchCustomer(customer);
            if (customers.Count < 1)
            {
                displayDataGridView.Rows.Clear();
                MessageBox.Show(" No record Found!!!");

            }
            else
            {
                BindCustomersListGridView(customers);
            }
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
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
                    customer.ActionType = "Insert";
                    if (customerManager.IsCustomerExist(customer) == 1)
                    {
                        MessageBox.Show("Customer Code '" + codeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        codeTextBox.Clear();
                        return;
                    }
                    else if (customerManager.IsCustomerExist(customer) == 2)
                    {
                        MessageBox.Show("Customer Contact '" + contactTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        contactTextBox.Clear();
                        return;
                    }
                    else if (customerManager.IsCustomerExist(customer) == 3)
                    {
                        MessageBox.Show("Customer Email '" + emailTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        emailTextBox.Clear();
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
                        customer.Id = Convert.ToInt32(customerIdLabel.Text);
                        customer.Code = codeTextBox.Text;
                        customer.Name = nameTextBox.Text;
                        customer.Address = addressTextBox.Text;
                        customer.Email = emailTextBox.Text;
                        customer.Contact = contactTextBox.Text;
                        customer.LoyaltyPoint = Convert.ToInt32(loaltyPointTextBox.Text);
                        customer.ActionType = "Update";
                        if (customerManager.IsCustomerExist(customer) == 1)
                        {
                            MessageBox.Show("Customer Code '" + codeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            codeTextBox.Clear();
                            return;
                        }
                        else if (customerManager.IsCustomerExist(customer) == 2)
                        {
                            MessageBox.Show("Customer Contact '" + contactTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            contactTextBox.Clear();
                            return;
                        }
                        else if (customerManager.IsCustomerExist(customer) == 3)
                        {
                            MessageBox.Show("Customer Email '" + emailTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            emailTextBox.Clear();
                            return;
                        }
                        else
                        {

                            customerManager.UpdateCustomer(customer);
                            customers = customerManager.ShowCustomer();
                            BindCustomersListGridView(customers);
                            ClearTextbox();
                            SaveButton.Text = "Save";
                            MessageBox.Show("Updated");
                        }

                        
                    }

                }
            }

        }

        private void ContactTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void DisplayDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DisplayDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayDataGridView.Rows[index];
            customerIdLabel.Text = Convert.ToString(selectedRow.Cells[1].Value);
            codeTextBox.Text = selectedRow.Cells[2].Value.ToString();
            nameTextBox.Text = selectedRow.Cells[3].Value.ToString();
            addressTextBox.Text = selectedRow.Cells[4].Value.ToString();
            emailTextBox.Text = selectedRow.Cells[5].Value.ToString();
            contactTextBox.Text = selectedRow.Cells[6].Value.ToString();
            loaltyPointTextBox.Text = selectedRow.Cells[7].Value.ToString();
            SaveButton.Text = "Update";
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            customers = customerManager.ShowCustomer();
            BindCustomersListGridView(customers);
        }
    }
}
