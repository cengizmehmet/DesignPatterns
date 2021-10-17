using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_Army
{
    class LeafSoldier : SoldierComponent
    {
        public LeafSoldier(string name, Enumerators.Ranks rank) : base(name, rank)
        {

        }

        public override void AddSoldier(SoldierComponent soldier)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteOrder(int count)
        {
            String dash = new String('-', count);
            Console.WriteLine(dash + _rank + " " + _name);
        }

        public override void RemoveSoldier(SoldierComponent soldier)
        {
            throw new NotImplementedException();
        }
    }
}
