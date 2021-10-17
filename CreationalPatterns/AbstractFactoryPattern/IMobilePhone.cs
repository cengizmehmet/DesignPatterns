﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Phone
{
    interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
