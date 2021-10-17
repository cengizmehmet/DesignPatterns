using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Airport
{
    public class PegasusAirline : AirlineBase
    {
        public PegasusAirline(string flightCode, IAirport airport) : base(flightCode, airport)
        {

        }

        public override void GetLandingPermission()
        {
            Console.WriteLine("Pegasus Airlines code " + FlightCode + " is requesting landing permission.");
            base.GetLandingPermission();
        }
    }
}
