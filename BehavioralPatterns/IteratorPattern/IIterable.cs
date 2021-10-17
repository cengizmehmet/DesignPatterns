using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern_Personel
{
    interface IIterable
    {
        IIterator GetIterator();
    }
}
