namespace WebAPITutorial.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebAPITutorial.Data;
using WebAPITutorial.Models;
using WebAPITutorial.Repositories;

public class ProductController : APIBaseController
{
    // private readonly DataContext _db;
    private IProductRepository _productRepository;

    // public ProductController(DataContext db){
    //     _db = db;
    // }
    public ProductController(IProductRepository productRepository){
        _productRepository = productRepository;
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        // var products = _db.Products.ToList();
        var products = _productRepository.GetAll().ToList();
        return Ok(products);
    }

    [HttpPost]
    public IActionResult AddNewProduct([FromBody]Product product)
    {
        if (product is null){
            return NotFound("Can't add the product");
        }

        // _db.Products.Add(product);
        // _db.SaveChanges();
        _productRepository.Add(product);
        _productRepository.Save();

        return Ok(product);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, Product? newProduct)
    {
        if(newProduct is null){
            return NotFound("New product update is invalid");
        }

        // Product existProduct = _db.Products.FirstOrDefault(c => c.ProductId == id);
        Product existProduct = _productRepository.Get(c => c.ProductId == id).FirstOrDefault();

        if (existProduct is null){
            return NotFound("Product doesn't exist");
        }

        if (newProduct.ProductName is not null){
            existProduct.ProductName = newProduct.ProductName;
        }
        if (newProduct.Description is not null){
            existProduct.Description = newProduct.Description;
        }
        
        // _db.SaveChanges();
        _productRepository.Save();

        return Ok(existProduct);

    }

}