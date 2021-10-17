using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_WarGame
{
    abstract class Human
    {
        string _type;
        double _range;

        public Human(string type)
        {
            _type = type;
            _range = 0;
        }

        public string GetHumanType()
        {
            return _type;
        }

        public double GetRange()
        {
            return _range;
        }

        public abstract int Cost();

        public abstract double Range();
    }
}
