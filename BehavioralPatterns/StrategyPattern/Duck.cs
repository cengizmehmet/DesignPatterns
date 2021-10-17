using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_Duck
{
    class Duck
    {
        private IFlyBehaviour _flyBehaviour;
        private IQuackBehaviour _quackBehaviour;
        private IDisplayBehaviour _displayBehaviour;
		

        public Duck()
        {

        }

        public Duck(IFlyBehaviour _flyBehaviour, IQuackBehaviour _quackBehaviour, IDisplayBehaviour _displayBehaviour)
        {
            this._flyBehaviour = _flyBehaviour;
            this._quackBehaviour = _quackBehaviour;
            this._displayBehaviour = _displayBehaviour;
        }

        public void SetFlyStrategy(IFlyBehaviour _flyBehaviour)
        {
            this._flyBehaviour = _flyBehaviour;
        }

        public void MakeADuck()
        {
            this._flyBehaviour.Fly();
            this._quackBehaviour.Quack();
            this._displayBehaviour.Display();
        }
    }
}
