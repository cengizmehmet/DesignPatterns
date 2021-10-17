using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_WarGame
{
    class Villager : Human
    {
        public Villager(string type) : base(type)
        {

        }

        public override int Cost()
        {
            return 1;
        }

        public override double Range()
        {
            return GetRange();
        }
    }
}
