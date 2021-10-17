using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_Spotify
{
    public interface IResources
    {
        string Snippet();
        string Title();
        //...
    }
}
