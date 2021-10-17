using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_Shopping
{
    public class Fridge : Shopping
    {
        public override void PaymentDetails()
        {
            paymentType = "INSTALMENT";
        }

        public override void Product()
        {
            productName = "Refrigator";
        }
    }
}
