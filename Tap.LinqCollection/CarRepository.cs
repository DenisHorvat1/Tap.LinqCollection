﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.LinqCollection
{
    public class CarRepository
    {
        public List<Car> cars = new List<Car>
            {
                new Car { Id = 1, Brand = "Dacia", Model = "Spring", IsElectric = true, AutonomyKm = 300,  MaxSpeedKmh = 120 },
                new Car { Id = 2, Brand = "VW", Model = "Polo", IsElectric = false, AutonomyKm = 850, MaxSpeedKmh = 180 },
                new Car { Id = 3, Brand = "Ford", Model = "Focus", IsElectric = false, AutonomyKm = 950, MaxSpeedKmh = 210 },
                new Car { Id = 4, Brand = "Tesla", Model = "Model 3", IsElectric = true, AutonomyKm =  500, MaxSpeedKmh = 260 },
                new Car { Id = 5, Brand = "Opel", Model = "Astra", IsElectric = false, AutonomyKm = 1010, MaxSpeedKmh = 190 }

            };
        public List<Car> GetAll()
        {

            return cars.Select(car => car).ToList();

        }

        public List<Car> GetSpeedCars()
        {

            return cars.Where(car => car.MaxSpeedKmh > 180)
                       .ToList();

        }
        public List<Car> GetHighAutonomyCars()
        {

            return cars.Where(car => car.IsElectric && car.AutonomyKm > 400)
                       .ToList();

        }

        public int GetNumberOfDecentCars()
        {

            return cars.Where(car => car.MaxSpeedKmh > 100 && car.MaxSpeedKmh < 200)
                       .ToList()
                       .Count();

        }

        public List<string> GetElectricCarBrands()
        {
            List<string> electricBrands = cars
                .Where(car => car.IsElectric)
                .Select(car => car.Brand)
                .Distinct()
                .ToList();

            return electricBrands;
        }

        public List<Car> GetCarsByPage(int pageNumber, int pageSize)
        {
            return cars.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        }
    }
}
