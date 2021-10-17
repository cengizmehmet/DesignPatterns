using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Animal
{
    class Bird : Animal
    {
        public override string Display()
        {
            return "BIRD!!!";
        }
    }
}
