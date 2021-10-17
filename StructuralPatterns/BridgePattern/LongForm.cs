using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_Spotify
{
    public class LongForm : View
    {

        public LongForm(IResources resource) : base(resource)
        {

        }

        public override string Show()
        {
            string display = "__________" + _resource.Title() + "__________\n-----------" + _resource.Snippet() + "-----------";

            return display;
        }
    }
}
