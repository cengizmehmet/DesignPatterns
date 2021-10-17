using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_Shopping
{
    public abstract class Shopping
    {
        protected string productName;
        protected string paymentType;

        public void TemplateMethod()
        {
            Start();
            Product();
            PaymentDetails();
            Finish();
        }

        void Start()
        {
            Console.WriteLine("SHOPPING STARTED!");
        }

        void Finish()
        {
            Console.WriteLine("SHOPPING FINISHED!\n{0} is sold with {1}", productName, paymentType);
        }

        abstract public void Product();
        abstract public void PaymentDetails();
    }
}
