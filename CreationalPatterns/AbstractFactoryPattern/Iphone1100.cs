using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Phone
{
    class Iphone1100 : INormalPhone
    {
        public string GetBateryLife()
        {
            return "Very long.";
        }
    }
}
