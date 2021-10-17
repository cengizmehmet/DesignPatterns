using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_WarGame
{
    class ToolDecorator : Human
    {
        protected Human _human;

        public ToolDecorator(Human human, string type) : base(type)
        {
            _human = human;
        }

        public override int Cost()
        {
            if (_human != null)
            {
                return _human.Cost();
            }
            else
            {
                return 0;
            }
        }

        public override double Range()
        {
            if (_human != null)
            {
                return _human.Range();
            }
            else
            {
                return 0;
            }
        }
    }
}
