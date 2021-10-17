using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("mc", "1234", "employee");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(employee1);
            folderProxy1.PerformFileOperations();

            Console.WriteLine();

            Employee employee2 = new Employee("mc", "1234", "manager");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(employee2);
            folderProxy2.PerformFileOperations();
        }
    }
}
