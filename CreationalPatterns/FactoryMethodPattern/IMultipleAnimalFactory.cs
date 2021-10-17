using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Animal
{
    public interface IMultipleAnimalFactory
    {
        List<Animal> CreateAnimals(int number);
    }
}
