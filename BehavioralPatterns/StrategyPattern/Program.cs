
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck wildDuck = new Duck(new JetFlyStrategy(), new QuackStrategy(), new DisplayAsGraphicsStrategy());

            wildDuck.MakeADuck();
        }
    }
}
