using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public bool IsApproved { get; set; }
    }
}