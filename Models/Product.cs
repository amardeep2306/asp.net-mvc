using System.Data.Entity;

namespace asp.net_mvc.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
    }

    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        { }
        public DbSet<Product> Products { get; set; }
    }
}