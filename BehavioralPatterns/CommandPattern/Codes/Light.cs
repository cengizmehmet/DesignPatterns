using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Light
{
    class Light
    {
        public void On()
        {
            Console.WriteLine("The light is on.");
        }
        public void Off()
        {
            Console.WriteLine("The light is off");
        }
    }
}
