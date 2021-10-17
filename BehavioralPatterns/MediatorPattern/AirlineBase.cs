using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Airport
{
    public abstract class AirlineBase
    {
        public string FlightCode { get; set; }
        public IAirport Airport { get; set; }

        public AirlineBase(string flightCode, IAirport airport)
        {
            this.FlightCode = flightCode;
            this.Airport = airport;
        }

        public virtual void GetLandingPermission()
        {
            if (Airport != null)
            {
                bool hasPermissionForLanding = Airport.GiveLandingPermission(FlightCode);

                if (hasPermissionForLanding)
                {
                    Console.WriteLine("Permission is granted!");
                }
                else
                {
                    Console.WriteLine("Permission denied.");
                }
            }
            else
                Console.WriteLine("Not registered. Permission denied.");
        }
    }
}
