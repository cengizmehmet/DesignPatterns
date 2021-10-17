using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class MobileObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Gecelerin Yargici Meqansiz Serseri");
        }
    }
}
