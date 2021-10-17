using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_CarFactory
{
    class BodyworkFactory
    {
        private SeatFactory Seat;
        public int SeatNumber { get; set; }
        public Enumerators.Colors Color { get; set; }

        public BodyworkFactory(EngineFactory engine, Enumerators.Colors color)
        {
            Seat = new SeatFactory();
            this.Color = color;
            if(engine.HP < 1000)
            {
                SeatNumber = Seat.GetSeatNumber(Enumerators.Bodies.Coupe);
            }
            else
            {
                SeatNumber = Seat.GetSeatNumber(Enumerators.Bodies.Sedan);
            }
        }
    }
}
