using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Lamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp();

            Console.WriteLine((lamp.GetState()).GetType());

            lamp.OnClosed();

            lamp.OnOpen();
        }
    }
}
