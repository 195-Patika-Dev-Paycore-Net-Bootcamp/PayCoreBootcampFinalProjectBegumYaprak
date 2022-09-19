using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using pycFinalApi.Data;
using pycFinalApi.Data.Model;
using pycFinalApi.Dto;
using pycFinalApi.Service;

namespace pycFinalApi.Controllers
{

    [ApiController]
    [Route("api/nhb/[controller]")]
    public class CategoryController : BaseController<CategoryDto, Category>
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;


        public CategoryController(ICategoryService categoryService, IMapper mapper) : base(categoryService, mapper)
        {
            this.mapper = mapper;
            this.categoryService = categoryService;
        }




    }
}
