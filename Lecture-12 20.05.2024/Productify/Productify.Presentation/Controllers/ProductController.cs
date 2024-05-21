using Microsoft.AspNetCore.Mvc;
using Productify.Application;
using Productify.Domain;

namespace MyApp.Namespace
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult GetProducts()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        public ActionResult AddProduct()
        {

            var product2 = new AddProductDto()
            {
                Name = "Product 2",
                Description = "Description 2",
            };

            var product3 = new AddProductDto()
            {
                Name = "Product 3",
                Description = "Description 3",
            };

            var product4 = new AddProductDto()
            {
                Name = "Product 4",
                Description = "Description 4",
            };

            var product5 = new AddProductDto()
            {
                Name = "Product 5",
                Description = "Description 5",
            };

            _productService.Add(product2);
            _productService.Add(product3);
            _productService.Add(product4);
            _productService.Add(product5);


            return View();
        }
    }
}
