namespace Sales.Domain.Models
{
    using System.Data.Entity;
    using Sales.Common.Models;


    public class DataContext: DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }

        //public DbSet<Product> Products { get; set; }
    }
}
