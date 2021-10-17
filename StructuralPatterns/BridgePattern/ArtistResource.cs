using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_Spotify
{
    public class ArtistResource : IResources
    {
        public string Snippet()
        {
            //GET SNIPPET VIA ADAPTER PATTERN
            return "Artist Snippet";
        }

        public string Title()
        {
            //GET TITLE VIA ADAPTER PATTERN
            return "Artist Title";
        }
    }
}
