using Microsoft.AspNetCore.Mvc;
using Productify.Application;

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

    }
}
