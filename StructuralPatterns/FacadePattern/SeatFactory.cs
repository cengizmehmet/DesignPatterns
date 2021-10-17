using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_CarFactory
{
    class SeatFactory
    {
        public int GetSeatNumber(Enumerators.Bodies body)
        {
            if(body == Enumerators.Bodies.Sedan)
            {
                return 4;
            }
            else
            {
                return 2;
            }
        }
    }
}
