using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.ViewCompenents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category {Name="Telefon", Description="Telefon kategorisi"},
                new Category {Name="Bilgisayar", Description="Bilgisayar kategorisi"},
                new Category {Name="Elektronik", Description="Elektronik kategorisi"}
            };

            return View(categories);
        }
    }
}