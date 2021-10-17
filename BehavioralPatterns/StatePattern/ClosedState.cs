using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Lamp
{
    public class ClosedState : ILampState
    {
        Lamp lamp;

        public ClosedState(Lamp lamp)
        {
            this.lamp = lamp;
        }

        public void OnClosed()
        {
            //Console.WriteLine("--CLOSED--");
        }

        public void OnOpen()
        {
            Console.WriteLine("HI THERE!");
            this.lamp.ChangeState(new OpenState(this.lamp));
        }
    }
}
