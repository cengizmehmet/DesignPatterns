using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_Spotify
{
    public abstract class View
    {
        public IResources _resource;

        public View(IResources resource)
        {
            this._resource = resource;
        }

        public abstract string Show();
    }
}
