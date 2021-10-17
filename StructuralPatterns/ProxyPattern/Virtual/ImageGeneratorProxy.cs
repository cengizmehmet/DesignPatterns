using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattern_ImageGenerator
{
    public class ImageGeneratorProxy : IImageGenerator
    {
        private ImageGenerator _imageGenerator;
        private Timer timer;
        private bool isLoaded = false;

        private void ShowRealImage(object o)
        {
            _imageGenerator = new ImageGenerator();
            _imageGenerator.ShowImage();
            isLoaded = true;
        }

        public void ShowImage()
        {
            if(_imageGenerator == null)
            {
                timer = new Timer(new TimerCallback(ShowRealImage), this, 2000, 0);
            }
            if(!isLoaded)
            {
                Console.WriteLine("SHOW PREVIEW");
            }
        }
    }
}
