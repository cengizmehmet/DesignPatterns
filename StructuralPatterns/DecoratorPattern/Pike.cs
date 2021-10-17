using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_WarGame
{
    class Pike : WeaponDecorator
    {
        public Pike(Human human, string type) : base(human, type)
        {

        }

        public override int Cost()
        {
            return base.Cost() + 2;
        }

        public override double Range()
        {
            return base.Range() + 1;
        }
    }
}
