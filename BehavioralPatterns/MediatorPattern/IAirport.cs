using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern_Airport
{
    public interface IAirport
    {
        void Register(AirlineBase airline);
        bool GiveLandingPermission(string flightCode);
    }
}
