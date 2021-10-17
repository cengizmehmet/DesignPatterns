using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    interface IHousePlan
    {
        void Basement(string basement);
        void Structure(string structure);
        void Roof(string roof);
        void Interior(string interior);
    }
}
