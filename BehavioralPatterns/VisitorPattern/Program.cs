﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern_ComputerParts
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerPart computer = new Computer();
            computer.Accept(new DisplayVisitor());
        }
    }
}
