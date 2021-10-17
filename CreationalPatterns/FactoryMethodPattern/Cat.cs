using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Animal
{
    class Cat : Animal
    {
        public override string Display()
        {
            return "CAT!!!";
        }
    }
}
