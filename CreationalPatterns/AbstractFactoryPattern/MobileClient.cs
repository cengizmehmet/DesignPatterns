using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern_Phone
{
    class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public MobileClient(IMobilePhone mobileClient)
        {
            smartPhone = mobileClient.GetSmartPhone();
            normalPhone = mobileClient.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return smartPhone.GetDescription();
        }

        public string GetNormalPhoneModelDetails()
        {
            return normalPhone.GetBateryLife();
        }
    }
}
