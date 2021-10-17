using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern_ComputerParts
{
    public interface IComputerPartVisitor
    {
        void Visit(IComputerPart computerPart);
    }
}
