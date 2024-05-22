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
            return RedirectToAction(nameof(GetAll));
        }

        // [HttpGet]
        // public ActionResult Edit()
        // {
        //     return View();
        // }

        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            var product = _productService.GetById(id);

            if (product is null)
                return View();
            
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(UpdateProductDto updateProductDto)
        {
            _productService.Update(updateProductDto);
            return RedirectToAction(nameof(GetAll));
        }

    }
}
