using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShopWeb.Models
{
    public class Car : Entity
    {
        public string Description { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Price { get; set; }
    }
}
