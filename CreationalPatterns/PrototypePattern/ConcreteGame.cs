using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_GameInfo
{
    public class ConcreteGame : IGamePrototype
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public ConcreteGame(int id, string name, string type)
        {
            ID = id;
            Name = name;
            Type = type;
        }

        public IGamePrototype Clone()
        {
            IGamePrototype game = new ConcreteGame(this.ID, this.Name, this.Type);
            //return this.MemberwiseClone() as GamePrototype;
            return game;
        }
    }
}
