using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern_Lamp
{
    public class Lamp
    {
        private ILampState lampState;

        public Lamp()
        {
            this.lampState = new ClosedState(this);
        }

        public void OnOpen()
        {
            this.lampState.OnOpen();
        }

        public void OnClosed()
        {
            this.lampState.OnClosed();
        }

        public void ChangeState(ILampState lampState)
        {
            this.lampState = lampState;
        }

        public ILampState GetState()
        {
            return this.lampState;
        }
    }
}
