using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap.LinqCollection
{
    public interface ICarRepository
    {
        public List<Car> GetAll();
    }
}
