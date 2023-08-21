using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppPartialViewExTwo.Models;

namespace WebAppPartialViewExTwo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Product()
        {
            List<Product> listproducts = new List<Product>()
            {
                new Product {ID=1, Name="Mobile", Price=23000, Brand="Samsung"},
                new Product {ID=2, Name="IPhone", Price=123000, Brand="Apple"},
                new Product {ID=3, Name="Laptop", Price=86000, Brand="Dell"},
                new Product {ID=4, Name="Vector", Price=98000, Brand="Dell"}
            };
            return PartialView(listproducts);
        }
    }
}