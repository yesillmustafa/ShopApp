using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        // localhost:5000/product/index
        public IActionResult Index()
        {
            var product = new Product {
                Name= "Iphone X",
                Price= 6000,
                Description= "İyi Telefon"
            };
            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category= "Telefonlar";
            // ViewBag.Product = product;

            return View(product);
        }
        // localhost:5000/product/list
        public IActionResult list()
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
        // localhost:5000/product/details
        public IActionResult Details(int id)
        {
            // ViewBag.Name = "samsung s6";
            // ViewBag.Price = 3000;
            // ViewBag.Description = "iyi telefon";

            var p = new Product();
            p.Name = "Samsung S6";
            p.Price = 3000;
            p.Description = "İyi Telefon";

            return View(p);
        }
    }
}