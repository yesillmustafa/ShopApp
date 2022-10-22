using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
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
        public IActionResult list(int? id)
        {

            var products = ProductRepository.Products;

            if(id!=null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }
        // localhost:5000/product/details
        public IActionResult Details(int id)
        {
            
            return View(ProductRepository.GetProductById(id));
        }
    }
}