using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            IAirport airport = new AtaturkAirport();

            AirlineBase thy1 = new THYAirline("THY 123", airport);
            AirlineBase thy2 = new THYAirline("THY 345", airport);
            AirlineBase pgs1 = new PegasusAirline("PGS 123", airport);

            airport.Register(thy1);
            airport.Register(pgs1);

            thy1.GetLandingPermission();
            thy2.GetLandingPermission();
            pgs1.GetLandingPermission();
        }
    }
}
