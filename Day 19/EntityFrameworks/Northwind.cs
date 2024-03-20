using EntityFrameworks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkTutorial;

public class Northwind : DbContext
{
	// public DbSet<Category> Categoriess { get; set; } // Table Name
    public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("Data Source=Nortwind.db");
	}
}