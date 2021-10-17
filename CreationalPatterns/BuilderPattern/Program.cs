using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IHouseBuilder flatHouse = new Flat();
            CivilEngineer engineer = new CivilEngineer(flatHouse);

            engineer.ConstructHouse();

            House house = engineer.GetHouse();

            Console.WriteLine("Builder constructed: " + house);
        }
    }
}
