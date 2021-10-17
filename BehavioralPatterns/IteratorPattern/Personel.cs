using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern_Personel
{
    class Personel
    {
        public int ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Personel(int id, string name, string surname)
        {
            ID = id;
            Name = name;
            Surname = surname;
        }
    }
}
