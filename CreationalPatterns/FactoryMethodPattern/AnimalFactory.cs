using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Animal
{
    class AnimalFactory
    {
        public Animal CreateAnimal(AnimalTypes animalType)
        {
            Animal animal = null;
            switch(animalType)
            {
                case AnimalTypes.Bird:
                    animal = new Bird();
                    break;
                case AnimalTypes.Cat:
                    animal = new Cat();
                    break;
                case AnimalTypes.Dog:
                    animal = new Dog();
                    break;
            }
            return animal;
        }
    }
}
