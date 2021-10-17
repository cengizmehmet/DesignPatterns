using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_BankCards
{
    public class Bank
    {
        public bool PaymentDoer(string cardNumber, int cost)
        {
            if (cost < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
