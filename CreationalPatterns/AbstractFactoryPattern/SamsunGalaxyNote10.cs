﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Phone
{
    class SamsunGalaxyNote10 : ISmartPhone
    {
        public string GetDescription()
        {
            return "Smart.";
        }
    }
}
