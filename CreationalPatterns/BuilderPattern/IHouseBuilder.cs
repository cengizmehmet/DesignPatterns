using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    interface IHouseBuilder
    {
        void BuildBasement();
        void BuildStructure();
        void BuildRoof();
        void BuildInterior();
        House GetHouse();
    }
}
