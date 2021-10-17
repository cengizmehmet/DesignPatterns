using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobilePhone samsung = new Samsung();
            MobileClient samsungClient = new MobileClient(samsung);
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine();

            IMobilePhone apple = new Apple();
            MobileClient appleClient = new MobileClient(apple);
            Console.WriteLine(appleClient.GetNormalPhoneModelDetails());
            Console.WriteLine(appleClient.GetSmartPhoneModelDetails());

        }
    }
}
