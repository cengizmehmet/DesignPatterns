﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("STOCK ALERT");
        }
    }
}
