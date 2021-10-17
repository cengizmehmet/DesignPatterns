using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_BankCards
{
    public class Client
    {
        IBankTarget bankTarget = new BankReader();

        public string PaymentResult(string cardNumber, int cost)
        {
            bool result = bankTarget.GetPayment(cardNumber, cost);

            if(result)
            {
                return "SUCCESS";
            }
            else
            {
                return "FAIL";
            }
        }

    }
}
