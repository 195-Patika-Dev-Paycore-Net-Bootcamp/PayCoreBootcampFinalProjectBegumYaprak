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
            
        
    }

    
}
