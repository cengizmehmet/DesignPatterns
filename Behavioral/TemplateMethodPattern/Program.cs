using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopping shopping1 = new TV();
            shopping1.TemplateMethod();
        }
    }
}
