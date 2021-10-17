using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_Employee
{
    public class SharedFolder : ISharedFolder
    {
        public void PerformFileOperations()
        {
            Console.WriteLine("PERFORMING R/W");
        }
    }
}
