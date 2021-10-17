using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern_ComputerParts
{
    public class DisplayVisitor : IComputerPartVisitor
    {
        public void Visit(IComputerPart computerPart)
        {
            if(computerPart.GetType().Name == "Monitor")
            {
                Console.WriteLine("Displaying monitor!");
            }
            else if(computerPart.GetType().Name == "Keyboard")
            {
                Console.WriteLine("Displaying keyboard!"); 
            }
            else if (computerPart.GetType().Name == "Computer")
            {
                Console.WriteLine("Displaying computer!");
            }
            else
            {
                Console.WriteLine("There is no such this part!");
            }
        }

        public void Visit (Monitor monitor)
        {
            Console.WriteLine("Hello monitor");
        }

        public void Visit (Keyboard keyboard)
        {
            Console.WriteLine("Hello keyboard");
        }
    }
}
