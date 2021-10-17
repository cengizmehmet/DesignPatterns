using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern_Employee
{
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _folder;
        private Employee employee;

        public SharedFolderProxy(Employee employee)
        {
            this.employee = employee;
        }

        public void PerformFileOperations()
        {
            if(employee.Role == "manager")
            {
                _folder = new SharedFolder();
                _folder.PerformFileOperations();
                Console.WriteLine("You have permission");
            }
            else
            {
                Console.WriteLine("You don't have permission!");
            }
        }
    }
}
