using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Duck
{
    class JetFlyStrategy : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Super saiyan");
        }
    }
}
