﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.LinqCollection
{
    internal class CarService
    {
        CarRepository carRepository;//

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }
    }
}
