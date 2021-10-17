using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern_Personel
{
    class Program
    {
        static void Main(string[] args)
        {
            IterablePersonel personels = new IterablePersonel();
            personels.AddPersonel(new Personel(1, "mehmet", "cengiz"));
            personels.AddPersonel(new Personel(2, "ayşe", "cengiz"));
            personels.AddPersonel(new Personel(3, "ayşe", "şimşek"));
            personels.AddPersonel(new Personel(4, "mehmet", "şimşek"));

            IIterator iterator = personels.GetIterator();
            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.CurrentPersonel().ID + " - " + iterator.CurrentPersonel().Name + " " +iterator.CurrentPersonel().Surname);
                iterator.NextPersonel();
            }
        }
    }
}
