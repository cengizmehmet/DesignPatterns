using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_GameInfo
{
    public interface IGamePrototype
    {
        IGamePrototype Clone();
    }
}
