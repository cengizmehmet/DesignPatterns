using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_BankCards
{
    public interface IBankTarget
    {
        bool GetPayment(string cardNumber, int cost);
    }
}
