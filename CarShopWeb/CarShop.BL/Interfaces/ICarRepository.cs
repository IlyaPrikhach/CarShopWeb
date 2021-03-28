using System;
using System.Collections.Generic;
using System.Text;
using СarShop.DataLayer.Entities;

namespace CarShop.BL.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int Id);
        void AddCarInShop(Car car);
        void DeleteCarFromShop(Car car);

    }
}
