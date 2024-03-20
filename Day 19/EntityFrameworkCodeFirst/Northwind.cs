using EntityFrameworkCodeFirst;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst;

public class Northwind : DbContext
{
  public DbSet<Category> Categories { get; set; }
  public DbSet<Product> Products { get; set; }
  public DbSet<Shipper> Shippers { get; set; }
  public DbSet<Order> Orders { get; set; }
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source=Northwind.db");
  }

}
