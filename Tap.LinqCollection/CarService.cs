using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.LinqCollection
{
    public class CarService : ICarRepository
    {
        public ICarRepository carRepository;

        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public List<Car> GetAll()
        {

            return carRepository.GetAll().Select(car => car).ToList();

        }
    }
}
