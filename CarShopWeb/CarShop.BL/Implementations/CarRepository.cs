using CarShop.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using СarShop.DataLayer;
using СarShop.DataLayer.Entities;

namespace CarShop.BL.Implementations
{
    public class CarRepository : ICarRepository
    {
        private EFDBContext context;

        public CarRepository(EFDBContext context)
        {
            this.context = context;
        }
        public void AddCarInShop(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
        }

        public void DeleteCarFromShop(Car car)
        {
            context.Cars.Remove(car);
            context.SaveChanges();
        }

        public IEnumerable<Car> GetAllCars()
        {
            return context.Cars.ToList();
        }

        public Car GetCarById(int Id)
        {
            return context.Cars.FirstOrDefault(x => x.Id == Id);
        }
    }
}
