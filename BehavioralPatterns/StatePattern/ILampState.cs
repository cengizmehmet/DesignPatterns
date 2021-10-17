using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Lamp
{
    public interface ILampState
    {
        void OnOpen();
        void OnClosed();
    }
}
