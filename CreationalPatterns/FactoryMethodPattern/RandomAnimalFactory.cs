using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Animal
{
    class RandomAnimalFactory : IMultipleAnimalFactory
    {
        public List<Animal> CreateAnimals(int number)
        {
            Random random = new Random();
            int num;
            List<Animal> animals = new List<Animal>();
            int enumNumber = Enum.GetNames(typeof(AnimalTypes)).Length;

            for (int i = 0; i < number; i++)
            {
                num = random.Next(enumNumber);

                switch (num)
                {
                    case (int)AnimalTypes.Cat:
                        animals.Add(new Cat());
                        break;
                    case (int)AnimalTypes.Dog:
                        animals.Add(new Dog());
                        break;
                    case (int)AnimalTypes.Bird:
                        animals.Add(new Bird());
                        break;
                    default:
                        animals.Add(null);
                        break;
                }
            }
            return animals;
        }
    }
}
