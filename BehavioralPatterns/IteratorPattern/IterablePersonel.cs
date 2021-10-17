using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern_Personel
{
    class IterablePersonel : IIterable
    {
        List<Personel> personels = new List<Personel>();
        public int Count { get => personels.Count; }

        public void AddPersonel(Personel personel)
        {
            personels.Add(personel);
        }

        public Personel GetPersonel(int index)
        {
            return personels[index];
        }

        public IIterator GetIterator()
        {
            return new PersonelIterator(this);
        }
    }
}
