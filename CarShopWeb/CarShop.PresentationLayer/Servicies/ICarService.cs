using CarShop.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.PresentationLayer.Servicies
{
    public interface ICarService
    {
        public List<CarViewModel> GetCarsList();
        public CarViewModel CarDBToViewModelById(int Id);
        public void AddCarInDB(CarViewModel _viewModel);
    }
}
