using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new RandomAnimalFactory().CreateAnimals(5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(animals[i].Display());
            }

            AnimalFactory animalFactory = new AnimalFactory();
            Animal animal1 = animalFactory.CreateAnimal(AnimalTypes.Cat);
            Animal animal2 = animalFactory.CreateAnimal(AnimalTypes.Dog);
            Console.WriteLine();
            Console.WriteLine(animal1.Display());
            Console.WriteLine(animal2.Display());

        }
    }
}
