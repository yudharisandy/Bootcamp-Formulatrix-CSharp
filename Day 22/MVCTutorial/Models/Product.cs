namespace MVCTutorial.Models;

public class Product
{
	public int ProductId { get; set; }
	public string ProductName { get; set; } = null!;
	public string? Description { get; set; }
	public int CategoryId { get; set; }
	public Category Category { get; set; } = null!;
}
