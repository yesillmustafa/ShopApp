using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.webui.Models;

namespace shopapp.webui.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1 ,Name = " Iphone 8" , Price = 3000, Description = "İyi telefon", IsApproved= false, ImageUrl = "1.jpg", CategoryId = 1},
                new Product { ProductId = 2 ,Name = " Iphone 7" , Price = 2000, Description = "İyi telefon", IsApproved= false, ImageUrl = "2.jpg", CategoryId = 1},
                new Product {ProductId = 3, Name = " Iphone 9" , Price = 4000, Description = "İyi telefon", IsApproved= false, ImageUrl = "3.jpg", CategoryId = 1},
                new Product { ProductId = 4 ,Name = " Iphone x" , Price = 6000, Description = "çok İyi telefon", IsApproved= true, ImageUrl = "4.jpg", CategoryId = 1},
                new Product { ProductId = 4 ,Name = " Iphone 11" , Price = 6000, Description = "çok İyi telefon", IsApproved= true, ImageUrl = "4.jpg", CategoryId = 1},
                new Product {ProductId = 5 ,Name = " Lenobo 8" , Price = 3000, Description = "İyi pc", IsApproved= false, ImageUrl = "1.jpg", CategoryId = 2},
                new Product { ProductId = 6 ,Name = " Lenovo 7" , Price = 2000, Description = "İyi pc", IsApproved= false, ImageUrl = "2.jpg", CategoryId = 2},
                new Product {ProductId = 7, Name = " Lenovo 9" , Price = 4000, Description = "İyi pc", IsApproved= false, ImageUrl = "3.jpg", CategoryId = 2},
                new Product { ProductId = 8 ,Name = " Lenovo x" , Price = 6000, Description = "çok İyi pc", IsApproved= true, ImageUrl = "4.jpg", CategoryId = 2}
            };
        }

        public static List<Product> Products {
            get{
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);

        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}