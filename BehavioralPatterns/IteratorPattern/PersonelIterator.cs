using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern_Personel
{
    class PersonelIterator : IIterator
    {
        IterablePersonel iterable;
        int currentIndex;

        public PersonelIterator(IterablePersonel iterable)
        {
            this.iterable = iterable;
        }

        public Personel CurrentPersonel()
        {
            return iterable.GetPersonel(currentIndex);
        }

        public bool HasNext()
        {
            if(currentIndex < iterable.Count)
            {
                return true;
            }
            return false;
        }

        public Personel NextPersonel()
        {
            if(HasNext())
            {
                return iterable.GetPersonel(currentIndex++);
            }
            return null;
        }
    }
}
