using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Duck
{
    class DisplayAsGraphicsStrategy : IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("***");
        }
    }
}
