using SBMS.Models;
using SBMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.BLL
{
    public class CustomerManager
    {
        CustomerRepository customerRepository = new CustomerRepository();

        public bool InsertCustomer(Customer customer)
        {

            return customerRepository.InsertCustomer(customer);
        }
        public bool UpdateCustomer(Customer customer)
        {

            return customerRepository.UpdateCustomer(customer);
        }
        public List<Customer> ShowCustomer()
        {
            return customerRepository.ShowCustomer();
        }
        public List<Customer> SearchCustomer(Customer customer)
        {
            return customerRepository.SearchCustomer(customer);
        }
        public int IsCustomerExist(Customer customer)
        {
            return customerRepository.IsCustomerExist(customer);
        }
        public Customer GetCustomerById(int id)
        {
            return customerRepository.GetCustomerById(id);
        }
        public bool UpdateCustomerLoyaltyPoint(Customer customer)
        {

            return customerRepository.UpdateCustomerLoyaltyPoint(customer);
        }
    }
}
