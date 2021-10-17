using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Phone
{
    class Apple : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new IphoneX();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Iphone1100();
        }
    }
}
