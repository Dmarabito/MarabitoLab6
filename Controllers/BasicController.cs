using MarabitoLab6.Models;
using Microsoft.AspNetCore.Mvc;
namespace MarabitoLab6.Controllers
{
    public class BasicController : Controller
    {

            public BasicController()
            {
            }
            public IActionResult Start()
            {
                return View();
            }
        public IActionResult ProductList()
        {
            var products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 999.99M, InStock = true },
        new Product { Id = 2, Name = "Headphones", Price = 149.99M, InStock = false },
        new Product { Id = 3, Name = "Mouse", Price = 49.99M, InStock = true }
    };
            ViewBag.ProductCount = products.Count;
            return View(products);
        }

    }
}
