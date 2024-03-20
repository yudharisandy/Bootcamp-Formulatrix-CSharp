using Microsoft.EntityFrameworkCore.Storage;
using EntityFrameworkTutorial;
using Microsoft.EntityFrameworkCore;
using EntityFrameworks;
class Program 
{
	static void Main() {
		using (Northwind db = new Northwind())
		{
			bool status = db.Database.CanConnect();
			Console.WriteLine($"Can connect: {status}");

            // ------------------------------------------------------------------------------------------
            
			//Retrieve

				//LINQ:
                    //Select
                    //Order
                    //OrderByDesc
                    //Where
                    //FirstOrDefault
                    //SelectMany
                
			List<Category> categories = db.Categories.ToList();
			foreach(var category in categories) 
			{
				Console.WriteLine($"{category.CategoryId} | {category.CategoryName} | {category.Description}");
			}

			Category? category1 = db.Categories.Find(1);
			Category? category2 = db.Categories.Where(c => c.CategoryId == 1).FirstOrDefault();

            string indicator = "Seafood";
            // string indicator = "SeafooD"; // Case-sensitive
			Category? result = db.Categories.Where(c => c.CategoryName.Contains(indicator)).FirstOrDefault();
			if (result != null)
			{
				Console.WriteLine($"{result.CategoryId} | {result.CategoryName} | {result.Description}");
			}
            System.Console.WriteLine("\n");

            
            { // Retrieve
                
                List<Order> orderList = db.Orders.ToList();
                foreach(var order in orderList){
                    System.Console.WriteLine($"{order.OrderID} | {order.ShipName} | {order.ShipCountry}");
                }
                System.Console.WriteLine($"Total order list: {orderList.Count}");
                System.Console.WriteLine("\n");
            }

            { // Retrieve the order that ShipCountry = France
                
                List<Order>? orderList = db.Orders.Where(c => c.ShipCountry == "France").ToList();
                if (orderList is not null){
                    foreach(var order in orderList){
                        System.Console.WriteLine($"{order.OrderID} | {order.ShipName} | {order.ShipCountry}");
                    }
                    System.Console.WriteLine("\n");  
                    System.Console.WriteLine($"Total France Order: {orderList.Count}");   
                    System.Console.WriteLine("\n");           
                }
            }

            { // Retrieve the order that ShipCountry = Indonesia
                List<Order>? orderList = db.Orders.Where(c => c.ShipCountry == "Indonesia").ToList();
                if (orderList is not null){
                    foreach(var order in orderList){
                        System.Console.WriteLine($"{order.OrderID} | {order.ShipName} | {order.ShipCountry}");
                    }
                    System.Console.WriteLine($"Total Indonesian Order: {orderList.Count}");   
                    System.Console.WriteLine("\n");           
                }
            }
            
            // ------------------------------------------------------------------------------------------

			// Create

			// Category category3 = new Category()
			// {
			// 	CategoryName = "Yanto",
			// 	Description = "Yanto is a human"
			// };
			// db.Categories.Add(category3);
			// db.SaveChanges();

            // Yanto was changed to "Yanti" manually in SQLite Studio: -> save
            // Category? yanti = db.Categories.Where(c => c.CategoryName == "Yanti").FirstOrDefault();
            // if (yanti is not null){
            //     Console.WriteLine($"{yanti.CategoryId} {yanti.CategoryName} {yanti.Description}");            
            // }
            // else{
            //     System.Console.WriteLine("Yanti is null");
            // }
            // System.Console.WriteLine("\n");
            
            { // Create a new Order (all properties in the class must be assigned to make the newOrder callable later)
                // Order newOrder = new Order(){
                //     OrderID = 99999,
                //     CustomerID = "ALFKI", // Must be something has been registered before. 
                //     EmployeeID = 1, // Must be something has been registered before.
                //     ShipName = "Evergreen Forever Green",
                //     ShipAddress = "Cebongan, Salatiga",
                //     ShipCountry = "Indonesia"
                // };
                // db.Orders.Add(newOrder);
                // db.SaveChanges();
            }

            // ------------------------------------------------------------------------------------------

			//Update
			// Category? yanto = db.Categories.Find(9);
			// //Category? yanto = db.Categories.Where(c => c.CategoryName == "Yanto").FirstOrDefault();
			// if (yanto != null)
			// {
			// 	yanto.Description = "Yanto was changed to Yanti";
			// 	db.SaveChanges();
			// }

            { // Update new Ship Address to existing data
                // Order? newOrder = db.Orders.Where(c => c.ShipCountry == "Indonesia").FirstOrDefault();
                // if(newOrder is not null){
                //     newOrder.ShipAddress = "Bogor 16680, West Java";
                //     db.SaveChanges();
                // }
            }

            // ------------------------------------------------------------------------------------------

			//Delete
            { 
                // string nameToBeDeleted = "Yanti";
                // Category? yanti = db.Categories.Where(c => c.CategoryName == nameToBeDeleted).FirstOrDefault(); 
                // if(yanti is not null) 
                // {
                //     db.Categories.Remove(yanti);
                //     db.SaveChanges();
                //     System.Console.WriteLine($"Deleted {nameToBeDeleted} successfully!");
                // }
            }

            // ------------------------------------------------------------------------------------------

			//Retrieve With the Product
			// string search = "Beverages";
            // string search = "ver";
            string search = "Con";
			IEnumerable<Category> categories2 = db.Categories
			.Where(c => c.CategoryName.Contains(search))
			.Include(c => c.Products).ToList(); //Include => Eager Loading
			
			foreach(var category in categories2) 
			{
				Console.WriteLine($"{category.CategoryId} {category.CategoryName} {category.Description}");
				Console.WriteLine(category.Products.Count());
				foreach(var product in category.Products) 
				{
					Console.WriteLine($"\t{product.ProductName}");
				}
			}
			
			// //Create new Product
			// Product product2 = new Product()
			// {
			// 	ProductName = "Yanto's Drink",
			// 	CategoryId = 1
			// };
			// db.Products.Add(product2);
			// db.SaveChanges();
		}
	}
}