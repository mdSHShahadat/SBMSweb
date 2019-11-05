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
using System.Text.RegularExpressions;

namespace SBMS.Ui
{
    public partial class SupplierUi : Form
    {
        public SupplierUi()
        {
            InitializeComponent();
        }
        Supplier _supplier=new Supplier();
        SupplierManager supplierManager = new SupplierManager();
        List<Supplier> suppliers = new List<Supplier>();
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
                    var supplier = new Supplier();
                    supplier.Code = codeTextBox.Text;
                    supplier.Name = nameTextBox.Text;
                    supplier.Address = addressTextBox.Text;
                    supplier.Email = emailTextBox.Text;
                    supplier.Contact = contactTextBox.Text;
                    supplier.ContactPerson = contactPersonTextBox.Text;
                    if (supplierManager.IsSupplierExist(supplier) == 1)
                    {
                        MessageBox.Show("Supplier Code '" + codeTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);                       
                        return;
                    }else
                    if (supplierManager.IsSupplierExist(supplier)== 2)
                    {
                        MessageBox.Show("Supplier Contact '" + contactTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                        return;
                    }
                    else if (supplierManager.IsSupplierExist(supplier) == 3)
                    {
                        MessageBox.Show("Supplier Email '" + emailTextBox.Text + "' already exist!", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);                       
                        return;
                    }
                    else
                    {
                        supplierManager.InsertSupplier(supplier);
                        suppliers = supplierManager.ShowSupplier();
                        BindSuppliersListGridView(suppliers);
                        ClearTextbox();
                        MessageBox.Show("Saved!!!");

                    }


                }
                else if(SaveButton.Text == "Update")
                {
                    if (IsFormValid())
                    {
                        var supplier = new Supplier();
                        supplier.Code = codeTextBox.Text;
                        supplier.Name = nameTextBox.Text;
                        supplier.Address = addressTextBox.Text;
                        supplier.Email = emailTextBox.Text;
                        supplier.Contact = contactTextBox.Text;
                        supplier.ContactPerson = contactPersonTextBox.Text;
                        _supplier.Code = supplier.Code;
                        _supplier.Name = supplier.Name;
                        _supplier.Address = supplier.Address;
                        _supplier.Email = supplier.Email;
                        _supplier.Contact = supplier.Contact;
                        _supplier.ContactPerson = supplier.ContactPerson;
                       
                            supplierManager.UpdateSupplier(_supplier);
                            suppliers = supplierManager.ShowSupplier();
                            BindSuppliersListGridView(suppliers);
                            ClearTextbox();
                            SaveButton.Text = "Save";

                        MessageBox.Show("Updated!!!");



                    }
                    

                }
                
            }
           

        }
        private void BindSuppliersListGridView(List<Supplier> suppliers)
        {
            int SL = 0;
            displayDataGridView.Rows.Clear();
            foreach (var supplier in suppliers)
            {
                SL++;
                displayDataGridView.Rows.Add(SL,supplier.Id, supplier.Code, supplier.Name,supplier.Address,supplier.Email,supplier.Contact,supplier.ContactPerson);
            }
        }
        private void SupplierUi_Load(object sender, EventArgs e)
        {
            suppliers = supplierManager.ShowSupplier();
            BindSuppliersListGridView(suppliers);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier();
            supplier.Contact = searchTextBox.Text;
            supplier.Name = searchTextBox.Text;
            supplier.Email = searchTextBox.Text;
            suppliers = supplierManager.SearchSupplier(supplier);
            if (suppliers.Count < 1)
            {
                displayDataGridView.Rows.Clear();
                MessageBox.Show("No records Found!!!");
            }
            else
            {
                BindSuppliersListGridView(suppliers);
            }
            
        }
        private bool IsFormValid()
        {
            if (codeTextBox.Text.ToString().Length !=4)
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
            //else if (codeTextBox.Text.Length != 4)
            //{
            //    MessageBox.Show("Code must be 4 characters in length!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    codeTextBox.Clear();
            //    return false;
            //}
            return true;
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
        private void DisplayDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var supplier = new Supplier();

            int index = e.RowIndex;
            DataGridViewRow selectedRow = displayDataGridView.Rows[index];
            _supplier.Id = Convert.ToInt32(selectedRow.Cells[1].Value);

            codeTextBox.Text = selectedRow.Cells[2].Value.ToString();
            nameTextBox.Text = selectedRow.Cells[3].Value.ToString();
            addressTextBox.Text = selectedRow.Cells[4].Value.ToString();
            emailTextBox.Text = selectedRow.Cells[5].Value.ToString();
            contactTextBox.Text = selectedRow.Cells[6].Value.ToString();
            contactPersonTextBox.Text = selectedRow.Cells[7].Value.ToString();
            SaveButton.Text = "Update";
        }
        private void ClearTextbox()
        {
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            contactPersonTextBox.Clear();
        }

        private void PreviousLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerUi customerUi = new CustomerUi();
            customerUi.Show();
            this.Close();
        }

        private void ExitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void NextLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseUi purchaseUi = new PurchaseUi();
            purchaseUi.Show();
            this.Hide();
        }
    }
}
