using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_ImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3500)
            {
                IImageGenerator _imageGenerator = new ImageGeneratorProxy();
                _imageGenerator.ShowImage();
                i++;
            }
        }
    }
}
