using Microsoft.AspNetCore.Mvc;

namespace WebAppPartialView.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
