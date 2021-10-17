using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_Spotify
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new LongForm(new ArtistResource());

            Console.WriteLine(view.Show());
        }
    }
}
