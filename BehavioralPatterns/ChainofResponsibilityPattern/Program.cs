using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityPattern_Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Withdraw withdraw = new Withdraw("C123", 50000, "TRY", "TR4532");

            Employee cashier = new Cashier();
            Employee manager = new Manager();
            Employee director = new Director();
            Employee areaManager = new AreaManager();

            cashier.SetNextApprover(manager);
            manager.SetNextApprover(director);
            director.SetNextApprover(areaManager);

            withdraw.Process(cashier);
        }
    }
}
