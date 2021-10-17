using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_WarGame
{
    class LongBow : WeaponDecorator
    {
        public LongBow(Human human, string type) : base(human, type)
        {

        }

        public override int Cost()
        {
            return base.Cost() + 3;
        }

        public override double Range()
        {
            return base.Range() + 4;
        }
    }
}
