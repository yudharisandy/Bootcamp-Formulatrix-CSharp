namespace WebAPITutorial.Repositories;

using WebAPITutorial.Models;

public interface ICategoryRepository : IRepository<Category>
{
	void Update(Category category);
}
