using CarShop.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using СarShop.DataLayer.Entities;

namespace CarShopWeb.Models
{
    public class AllCarsModel
    {
        public List<CarViewModel> cars { get; set; }
    }
}
