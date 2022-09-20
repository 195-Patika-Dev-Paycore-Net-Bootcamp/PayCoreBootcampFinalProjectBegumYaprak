using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using pycFinalApi.Data.Model;
using pycFinalApi.Dto;
using pycFinalApi.Service;

namespace pycFinalApi.Controllers
{

    [ApiController]
    [Route("api/nhb/[controller]")]
    public class ProductController : BaseController<ProductDto, Product>
    {

        private readonly IProductService productService;
        private readonly IMapper mapper;

        public ProductController(IProductService productService, IMapper mapper) : base(productService, mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }


        [HttpPost]
        public override IActionResult Create([FromBody] ProductDto dto)
        {
            
            var result = productService.Insert(dto);

            if (!result.Success)
            {
                return BadRequest(result);
            }

            if (result.Response is null)
            {
                return NoContent();
            }

            if (result.Success)
            {
                return StatusCode(201, result);
            }

            return BadRequest(result);
        }
    }

    
}
