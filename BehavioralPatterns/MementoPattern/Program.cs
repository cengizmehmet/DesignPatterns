using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern_Settings
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();

            Settings settings = new Settings();
            settings.UserName = "Mehmet";
            settings.Password = "123456";
            settings.Email = "mehmet.cengiz@adu.edu.tr";
            settings.RememberMe = true;

            Console.WriteLine(settings.Display() + Environment.NewLine);

            caretaker.Memento = settings.Backup();

            settings.Password = "654321";
            settings.RememberMe = false;

            Console.WriteLine(settings.Display() + Environment.NewLine);
            
            settings.GetDefaultSettings(caretaker.Memento);

            Console.WriteLine(settings.Display());
        }
    }
}
