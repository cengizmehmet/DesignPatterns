using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Phone
{
    class Samsung : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsunGalaxyNote10();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Samsung3310();
        }
    }
}
