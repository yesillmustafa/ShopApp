using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product { Name = " Iphone 8" , Price = 3000, Description = "İyi telefon", IsApproved= false},
                new Product { Name = " Iphone 7" , Price = 2000, Description = "İyi telefon", IsApproved= false},
                new Product { Name = " Iphone 9" , Price = 4000, Description = "İyi telefon", IsApproved= false},
                new Product { Name = " Iphone x" , Price = 6000, Description = "çok İyi telefon", IsApproved= true}
            };

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }
        // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}