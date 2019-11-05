using SBMS.Models;
using SBMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.BLL
{
    public class ProductManager
    {
        ProductRepository productRepository = new ProductRepository();

        public bool InsertProduct(Product product)
        {
            return productRepository.InsertProduct(product);
        }
        public bool UpdateProduct(Product product)
        {
            return productRepository.UpdateProduct(product);
        }
        public List<Product> ShowProduct()
        {
            return productRepository.ShowProduct();

        }
        public List<Product> SearchProduct(Product product)
        {
            return productRepository.SearchProduct(product);
        }
        public int IsProductExist(Product product)
        {
            return productRepository.IsProductExist(product);
        }
        public List<Product> ShowProductById(int id)
        {
            return productRepository.ShowProductById(id);
        }
        public Product SearchById(int id)
        {

            return productRepository.SearchById(id);
        }
    }
}
