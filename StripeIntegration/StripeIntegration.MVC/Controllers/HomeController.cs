using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;

namespace StripeIntegration.MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult GoPayment()
    {
        StripeConfiguration.ApiKey = "sk_test_51PXjN0BuMoTa3aiJYyLc9ivNalYSsTKdEdPIcgayCll4484JDwBaX2qBoGb3Ky7UkRDLVRe4dtKZSTXjRWzxZWfA00SKueiTCC";

        return View();
    }

    [HttpPost]
        public ActionResult GoPayment(string productId)
        {
            var domain = "http://localhost:4242";
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                    // Provide the exact Price ID (for example, pr_1234) of the product you want to sell
                    Price = productId,
                    Quantity = 1,
                  },
                },
                Mode = "payment",
                SuccessUrl = domain + "/success.html",
                CancelUrl = domain + "/cancel.html",
            };
            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
}
