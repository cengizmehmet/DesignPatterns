using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Attach(new CustomerObserver());
            product.Attach(new MobileObserver());

            product.ChangeStock();
        }
    }
}
