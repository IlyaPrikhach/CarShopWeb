using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace СarShop.DataLayer.Entities
{
    public class Car
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBought { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
    }
}
