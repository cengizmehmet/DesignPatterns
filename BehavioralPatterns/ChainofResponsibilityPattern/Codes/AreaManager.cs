using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern_Banking
{
    public class AreaManager : Employee
    {
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 750000)
            {
                Console.WriteLine(req.Amount + " withdrawal was approved by " + this.GetType().Name);
            }
            else
            {
                Console.WriteLine("Because of daily limit exceed, " + req.Amount + " withdrawal is denied");
            }
        }
    }
}
