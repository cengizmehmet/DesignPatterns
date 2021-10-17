using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_CarFactory
{
    class GearboxFactory
    {
        public int GetGearNumber(int hp)
        {
            if (hp > 1000)
            {
                return 5;
            }
            else
            {
                return 4;
            }
        }
    }
}
