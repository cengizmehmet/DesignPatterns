using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_CarFactory
{
    class EngineFactory
    {
        public int HP { get; }
        public GearboxFactory Gearbox { get; set; }
        public int GearNumber { get; set; }

        public EngineFactory(int hp)
        {
            this.HP = hp;
            Gearbox = new GearboxFactory();
            GearNumber = Gearbox.GetGearNumber(this.HP);
        }

    }
}
