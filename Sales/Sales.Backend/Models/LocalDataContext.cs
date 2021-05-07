namespace Sales.Backend.Models
{
    using Sales.Common.Models;
    using Sales.Domain.Models;    

    public class LocalDataContext: DataContext
    {
       public System.Data.Entity.DbSet<Product> Products { get; set; }
    }
}