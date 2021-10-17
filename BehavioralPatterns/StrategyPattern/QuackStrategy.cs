using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Duck
{
    class QuackStrategy : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("\a");
        }
    }
}
