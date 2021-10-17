using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Duck
{
    class DisplayAsTextStrategy : IDisplayBehaviour
    {
        public void Display()
        {
            Console.WriteLine("DUCK");
        }
    }
}
