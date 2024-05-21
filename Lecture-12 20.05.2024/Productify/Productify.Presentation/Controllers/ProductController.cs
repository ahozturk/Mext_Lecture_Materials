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

        public ActionResult GetAll()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AddProductDto addProductDto)
        {
            _productService.Add(addProductDto);
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(UpdateProductDto updateProductDto)
        {
            _productService.Update(updateProductDto);
            return View();
        }

    }
}
