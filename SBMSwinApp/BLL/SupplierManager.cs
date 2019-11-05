using SBMS.Models;
using SBMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.BLL
{
    public class SupplierManager
    {
        SupplierRepository supplierRepository= new SupplierRepository();

        public bool InsertSupplier(Supplier supplier)
        {

            return supplierRepository.InsertSupplier(supplier);
        }
        public bool UpdateSupplier(Supplier supplier)
        {

            return supplierRepository.UpdateSupplier(supplier);
        }
        public List<Supplier> ShowSupplier()
        {
            return supplierRepository.ShowSupplier();

        }
        public List<Supplier> SearchSupplier(Supplier supplier)
        {
            return supplierRepository.SearchSupplier(supplier);
        }
        public int IsSupplierExist(Supplier supplier)
        {
            return supplierRepository.IsSupplierExist(supplier);
        }
    }
}
