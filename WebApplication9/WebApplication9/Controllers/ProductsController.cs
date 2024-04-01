using WebApplication9.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication9.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product {ID = 1, Name = "iPhone 13", Price = 899.00m},
                new Product {ID = 2, Name = "MacBook Air", Price = 1199.00m },
                new Product {ID = 3, Name = "iPad Air", Price = 649.00m },
                new Product {ID = 4, Name = "Apple Watch Series 7", Price = 459.00m },
                new Product {ID = 5, Name = "Amazon Kindle Paperwhite", Price = 129.99m },
                new Product {ID = 6, Name = "PlayStation 5", Price = 599.00m },
                new Product {ID = 7, Name = "Fitbit Charge 5", Price = 179.95m }

            };

            return View(products);
        }
    }

}
