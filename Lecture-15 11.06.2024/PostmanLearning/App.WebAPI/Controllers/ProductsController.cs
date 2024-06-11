using App.WebAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            Console.WriteLine($"Products/GetById - {id} Triggered");
            
            return Ok($"Product {id}");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            Console.WriteLine("Products/GetAll Triggered");
            return Ok(new List<string> { "Product 1", "Product 2", "Product 3" });
        }

        [HttpPost]
        public IActionResult Create([FromBody]ProductCreateDto productCreateDto)
        {
            Console.WriteLine($"Products/Create - {productCreateDto.Name} Triggered");
            return Ok();
        }
    }
}
