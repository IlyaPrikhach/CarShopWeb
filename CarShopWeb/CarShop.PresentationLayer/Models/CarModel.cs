using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarShop.PresentationLayer.Models
{
    public class CarViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBought { get; set; } = false;
        public int ManufactureYear { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
    }
}
