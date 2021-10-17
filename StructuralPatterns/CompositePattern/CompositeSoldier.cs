using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_Army
{
    class CompositeSoldier : SoldierComponent
    {
        private List<SoldierComponent> _soldiers = new List<SoldierComponent>();

        public CompositeSoldier(string name, Enumerators.Ranks rank) : base(name, rank)
        {

        }

        public override void AddSoldier(SoldierComponent soldier)
        {
            _soldiers.Add(soldier);
        }

        public override void ExecuteOrder(int count)
        {
            String dash = new string('-', count++);
            Console.WriteLine(dash + _rank + " " + _name);
            foreach(SoldierComponent soldier in _soldiers)
            {
                soldier.ExecuteOrder(count);
            }
        }

        public override void RemoveSoldier(SoldierComponent soldier)
        {
            _soldiers.Remove(soldier);
        }
    }
}
