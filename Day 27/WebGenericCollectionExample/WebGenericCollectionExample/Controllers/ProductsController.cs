using Microsoft.AspNetCore.Mvc;
using WebGenericCollectionExample.Models;

namespace WebGenericCollectionExample.Controllers
{
    public class ProductsController : Controller
    {
        static List<Product> productsList = new List<Product>()
        {
            new Product {ID=1, Name="Herbal Shampoo", Description="For your strong and healthy hair"},
            new Product {ID=2, Name="Fair&Glow", Description="For yourfair Skin"},
            new Product {ID=3, Name="Dabur Honey", Description="For ntural sweet"},
            new Product {ID=4, Name="Face Wash", Description="For your clean and healthy skin"}

        };
        public IActionResult Index()
        {
            return View(productsList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            productsList.Add(product);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
           Product product = productsList.Find(x => x.ID == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            int id = product.ID;
            Product delPro = productsList.Find(x => x.ID==id);
            if(delPro == null)
            {
                Console.WriteLine("Problem in Fetching Details");
            }
            else
            {
                productsList.Remove(delPro);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Product product = productsList.Find(x => x.ID == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            int id = product.ID;
            Product editPro = productsList.Find (x => x.ID == id);

            if(editPro == null)
            {
                return Problem("ERROR!");
            }
           
            editPro.Name = product.Name;
            editPro.Description = product.Description;
            //productsList.Remove(editPro);
            //productsList.Add(product);
            return RedirectToAction("Index");

        }
    }
}
