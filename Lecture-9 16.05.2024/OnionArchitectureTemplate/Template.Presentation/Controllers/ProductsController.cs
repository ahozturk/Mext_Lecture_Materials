using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Template.Application;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult Add(AddProductDto addProductDto)
        {
            _productService.Add(addProductDto);

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery]Paginition paginition)
        {
            return Ok(_productService.GetAll(paginition));
        }

        [HttpPut]
        public IActionResult Update(Guid id, AddProductDto addProductDto)
        {
            _productService.Update(id, addProductDto);

            return Ok();
        }
    }
}
