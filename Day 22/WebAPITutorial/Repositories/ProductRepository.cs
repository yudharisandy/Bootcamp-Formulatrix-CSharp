namespace WebAPITutorial.Repositories;

using WebAPITutorial.Data;
using WebAPITutorial.Models;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly DataContext _db;
    public ProductRepository(DataContext db) : base(db)
    {
        _db = db;
    }
    public void Update(Product product)
    {
        _db.Products.Update(product);
    }
}
