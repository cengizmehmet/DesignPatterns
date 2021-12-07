using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Light
{
    class RemoteController
    {
        ICommand _on;
        ICommand _off;

        public RemoteController(ICommand _on, ICommand _off)
        {
            this._on = _on;
            this._off = _off;
        }

        public void ClickOn()
        {
            this._on.Execute();
        }

        public void ClickOff()
        {
            this._off.Execute();
        }
    }
}
