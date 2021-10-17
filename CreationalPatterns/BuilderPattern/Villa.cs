using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Villa : IHouseBuilder
    {
        private House house;

        public Villa()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            house.Basement("Shelter typed");
        }

        public void BuildInterior()
        {
            house.Interior("Open kitchen");
        }

        public void BuildStructure()
        {
            house.Structure("Wooden");
        }

        public void BuildRoof()
        {
            house.Roof("Shingle");
        }

        public House GetHouse()
        {
            return this.house;
        }
    }
}
