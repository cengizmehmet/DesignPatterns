using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Airport
{
    public class THYAirline : AirlineBase
    {
        public THYAirline(string flightCode, IAirport airport) : base(flightCode, airport)
        {

        }

        public override void GetLandingPermission()
        {
            Console.WriteLine("Turkish Airlines code " + FlightCode + " is requesting landing permission.");
            base.GetLandingPermission();
        }
    }
}
