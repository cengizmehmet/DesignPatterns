using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade(Enumerators.Colors.Red, 1500);
            Car car = facade.GetCar();

            Console.WriteLine(car.bodywork.Color);
            Console.WriteLine(car.engine.HP);
        }
    }
}
