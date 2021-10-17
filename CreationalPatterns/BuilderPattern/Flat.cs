using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Flat : IHouseBuilder
    {
        private House house;

        public Flat()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            house.Basement("Common basement");
        }

        public void BuildInterior()
        {
            house.Interior("160m2");
        }

        public void BuildStructure()
        {
            house.Structure("Steel");
        }

        public void BuildRoof()
        {
            house.Roof("Terraced Roof");
        }

        public House GetHouse()
        {
            return this.house;
        }
    }
}
