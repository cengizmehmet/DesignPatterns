using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class CivilEngineer
    {

        private IHouseBuilder houseBuilder;

        public CivilEngineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public House GetHouse()
        {
            return this.houseBuilder.GetHouse();
        }

        public void ConstructHouse()
        {
            this.houseBuilder.BuildBasement();
            this.houseBuilder.BuildStructure();
            this.houseBuilder.BuildRoof();
            this.houseBuilder.BuildInterior();
        }
    }
}
