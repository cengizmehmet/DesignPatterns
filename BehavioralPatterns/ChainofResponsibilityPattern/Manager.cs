using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern_Banking
{
    public class Manager : Employee
    {
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 70000)
            {
                Console.WriteLine(req.Amount + " withdrawal was approved by " + this.GetType().Name);
            }
            else if (NextApprover != null)
            {
                Console.WriteLine("Because of maximum limit exceed, " + req.Amount + " withdrawal process is waiting an approval from " + this.NextApprover.GetType().Name);

                NextApprover.ProcessRequest(req);
            }
        }
    }
}
