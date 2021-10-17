using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_BankCards
{
    public class BankReader : IBankTarget
    {
        private Bank bank = new Bank();

        public bool GetPayment(string cardNumber, int cost)
        {
            return this.bank.PaymentDoer(cardNumber, cost);
        }
    }
}
