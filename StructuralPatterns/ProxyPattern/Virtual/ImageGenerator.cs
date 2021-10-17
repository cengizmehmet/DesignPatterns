using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_ImageGenerator
{
    public class ImageGenerator : IImageGenerator
    {
        public void ShowImage()
        {
            Console.WriteLine("LOADING...");
        }
    }
}
