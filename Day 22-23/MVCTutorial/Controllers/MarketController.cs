using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using MVCTutorial.Data;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers;

public class MarketController : Controller
{
    private readonly DataContext _context;
    public MarketController(DataContext context){
        _context = context;
    }
	public IActionResult Index()
	{
        var products = _context.Products;
		return View(products);
	}
}
