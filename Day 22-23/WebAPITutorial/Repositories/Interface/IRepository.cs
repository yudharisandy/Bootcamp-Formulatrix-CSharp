namespace WebAPITutorial.Repositories;

using System.Linq.Expressions;

public interface IRepository<T> where T : class
{
	IEnumerable<T> GetAll();
	IEnumerable<T> Get(Expression<Func<T, bool>> expression);
	bool Add(T entity);
	bool AddRange(IEnumerable<T> entities);
	bool Remove(T entity);
	bool RemoveRange(IEnumerable<T> entities);
	int Save();
}