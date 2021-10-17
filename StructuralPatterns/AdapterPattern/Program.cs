using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_BankCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine(client.PaymentResult("12334", 150));
        }
    }
}
