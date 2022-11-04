using System.Data.Entity;

namespace asp.net_mvc.Models
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }

    public class FlowerDBContext : DbContext
    {
        public FlowerDBContext()
        { }
        public DbSet<Flower> Flowers { get; set; }
    }
}