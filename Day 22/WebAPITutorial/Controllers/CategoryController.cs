namespace WebAPITutorial.Controllers;

using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPITutorial.Data;
using WebAPITutorial.Models;
using WebAPITutorial.Models.DTOs;
using AutoMapper;
using WebAPITutorial.Repositories;

public class CategoryController : APIBaseController
{
	// private readonly DataContext _db;
	private ICategoryRepository _categoryRepository;
	private IMapper _mapper;
	
	// public CategoryController(DataContext db, IMapper mapper)
	// {
	// 	_db = db;
	// 	_mapper = mapper;
	// }
	public CategoryController(IMapper mapper, ICategoryRepository categoryRepository)
	{
		// _db = db;
		_categoryRepository = categoryRepository;
		_mapper = mapper;
	}

	[HttpGet]
	public IActionResult GetAllCategory()
	{
		// var categories = _db.Categories.Include(c => c.Products).ToList();
		var categories = _categoryRepository.GetAll().ToList();

		// Add DTO Manually
		// List<CategoryDTO> categoryDTOs = new();
		// foreach(var category in categories){
		// 	categoryDTOs.Add(new CategoryDTO{
		// 		CategoryName = category.CategoryName,
		// 		Description = category.Description
		// 	});
		// }

		// Add DTO by using AutoMapper
		List<CategoryDTO> categoryDTOs = _mapper.Map<List<CategoryDTO>>(categories);

		return Ok(categoryDTOs);
	}

	[HttpGet("{id}")]
	public IActionResult GetCategory(int id)
	{
		// var category = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);
		var category = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();
		if (category == null)
		{
			return NotFound();
		}
		return Ok(category);
	}

	[HttpPost]
	public IActionResult AddCategory([FromBody]CategoryDTO? categoryDTO) 
	{
		if(categoryDTO is null) 
		{
			return NotFound("Category not found");
		}

		// Add DTOs Manually
		// Category category = new Category{
		// 	CategoryName = categoryDTO.CategoryName,
		// 	Description = categoryDTO.Description
		// };

		// Add DTOs by using AutoMapper
		Category category = _mapper.Map<Category>(categoryDTO);

		// _db.Categories.Add(category);
		// _db.SaveChanges();
		_categoryRepository.Add(category);
		_categoryRepository.Save();

		return Ok(category);
	}

	[HttpPut("{id}")]
	public IActionResult UpdateCategory(int id, Category? category) 
	{
		if(category is null) 
		{
			return NotFound("Category not found!");
		}
		// var existingCategory = _db.Categories.FirstOrDefault(c => c.CategoryId == id);
		var existingCategory = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();

		if(existingCategory is null) 
		{
			return NotFound(
				$"Category with id {id} not found!"
			);
		}
		if(category.CategoryName != null)
		{
			existingCategory.CategoryName = category.CategoryName;
		}
		if(category.Description != null)
		{
			existingCategory.Description = category.Description;
		}

		// _db.SaveChanges();
		_categoryRepository.Save();

		return Ok(existingCategory);
	}

	[HttpPatch("{id}")]
	public IActionResult UpdateCategoryPatch(int id, Category? category)
	{
		if(category is null) 
		{
			return NotFound("Category not found!");
		}
		// var existingCategory = _db.Categories.FirstOrDefault(c => c.CategoryId == id);
		var existingCategory = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();

		if(existingCategory is null) 
		{
			return NotFound(
				$"Category with id {id} not found!"
			);
		}
		if(category.CategoryName != null)
		{
			existingCategory.CategoryName = category.CategoryName;
		}
		if(category.Description != null)
		{
			existingCategory.Description = category.Description;
		}

		// _db.SaveChanges();
		_categoryRepository.Save();

		return Ok(existingCategory);
	}

	[HttpDelete("{id}")]
	public IActionResult Delete(int? id)
	{
		if(id is null || id == 0){
			return NotFound();
		}
		// var deletedCategory = _db.Categories.Find(id);
		var deletedCategory = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();

		if(deletedCategory is null){
			return NotFound();
		}

		// _db.Categories.Remove(deletedCategory);
		// _db.SaveChanges();
		_categoryRepository.Remove(deletedCategory);
		_categoryRepository.Save();
		
		return Ok(deletedCategory);
	}
}