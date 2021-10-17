using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern_Shopping
{
    public class TV : Shopping
    {
        public override void PaymentDetails()
        {
            paymentType = "CASH!";
        }

        public override void Product()
        {
            productName = "Television";
        }
    }
}
