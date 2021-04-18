using System;
using System.Collections.Generic;
using System.Text;
using CarShop.PresentationLayer.Models;
using CarShop.BL.Implementations;
using System.Linq;
using СarShop.DataLayer.Entities;
using CarShop.BL.Interfaces;

namespace CarShop.PresentationLayer.Servicies
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<CarViewModel> GetCarsList()
        {
            var _cars = _carRepository.GetAllCars().ToList();
            List<CarViewModel> _modelsList = new List<CarViewModel>();
            foreach (var item in _cars)
            {
                _modelsList.Add(CarDBToViewModelById(item.Id));
            }
            return _modelsList;
        }

        public CarViewModel CarDBToViewModelById(int Id)
        {
            var _cars = _carRepository.GetCarById(Id);

            return new CarViewModel()
            {
                Description = _cars.Description,
                IsBought = _cars.IsBought,
                ManufactureYear = _cars.ManufactureYear,
                Name = _cars.Name,
                Price = _cars.Price,
                Id = _cars.Id
            };
        }

        public void AddCarInDB(CarViewModel _viewModel)
        {
            _carRepository.AddCarInDB(new Car()
            {
                Description = _viewModel.Description,
                IsBought = false,
                ManufactureYear = _viewModel.ManufactureYear,
                Name = _viewModel.Name,
                Price = _viewModel.Price
            });
        }


    }
}
