using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Duck
{
    class SimpleFlyStrategy : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I believe I can fly");
        }
    }
}
