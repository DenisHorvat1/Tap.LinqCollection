using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.LinqCollection
{
    public class CarService : ICarRepository
    {
        public CarRepository carRepository;

        public CarService(CarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public List<Car> GetAll()
        {

            return cars.Select(car => car).ToList();

        }
    }
}
