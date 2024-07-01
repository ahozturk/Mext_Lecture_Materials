using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace StripeIntegration.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
