using AutoMapper;
using WebAPITutorial.Models;
using WebAPITutorial.Models.DTOs;
namespace WebAPITutorial.Map;

public class MyMapper : Profile
{
	public MyMapper()
	{
		//CreteMap<Destination, Source>
		CreateMap<CategoryDTO, Category>().ReverseMap();
		//CreateMap<Category, CategoryDTO>()
		//CreateMap<CategoryDTO, Category>()
	}
}