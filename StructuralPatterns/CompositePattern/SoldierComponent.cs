using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_Army
{
    abstract class SoldierComponent
    {
        protected string _name;
        protected Enumerators.Ranks _rank;

        public SoldierComponent(string name, Enumerators.Ranks rank)
        {
            _name = name;
            _rank = rank;
        }

        public abstract void AddSoldier(SoldierComponent soldier);
        public abstract void RemoveSoldier(SoldierComponent soldier);
        public abstract void ExecuteOrder(int count);
    }
}
