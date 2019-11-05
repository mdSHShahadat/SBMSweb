

using SBMSwebApp.Models.Models;
using System.Data.Entity;

namespace SBMSwebApp.DatabaseContext.DatabaseContext
{
    public class SBMSdbContext:DbContext
    {
        public SBMSdbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers{ get; set; }

    }
}
