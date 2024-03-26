namespace WebAPITutorial.Repositories;

using WebAPITutorial.Models;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product product);
}
