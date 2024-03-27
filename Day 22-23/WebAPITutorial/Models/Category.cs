namespace WebAPITutorial.Models;

using System.ComponentModel;

public class Category
{
	public int CategoryId { get; set; }
	// [DisplayName("Cek")]
	public string CategoryName { get; set; } = null!;
	public string? Description { get; set; }
	public ICollection<Product> Products { get; set; }
	
	public Category()
	{
		Products = new List<Product>();
	}
}
