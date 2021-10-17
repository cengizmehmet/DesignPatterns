using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Lamp
{
    public class OpenState : ILampState
    {
        Lamp lamp;

        public OpenState(Lamp lamp)
        {
            this.lamp = lamp;
        }

        public void OnClosed()
        {
            Console.WriteLine("Byesss");
            this.lamp.ChangeState(new ClosedState(this.lamp));
        }

        public void OnOpen()
        {
            //Console.WriteLine("--OPEN--");
        }
    }
}
