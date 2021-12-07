using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern_Banking
{
    public class Withdraw
    {
        public string CustomerId { get; }
        public decimal Amount { get; }
        public string CurrencyType { get; }
        public string SourceAccountId { get; }

        public Withdraw(string customerId, decimal amount, string currencyType, string sourceAccountId)
        {
            CustomerId = customerId;
            Amount = amount;
            CurrencyType = currencyType;
            SourceAccountId = sourceAccountId;
        }

        public void Process(Employee employee)
        {
            employee.ProcessRequest(this);
        }
    }
}
