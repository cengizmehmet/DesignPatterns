using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_GameInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            IGamePrototype game = new ConcreteGame(1, "HOI4", "Strategy");
            IGamePrototype game1 = (ConcreteGame)game.Clone();
            IGamePrototype game2 = game;
            IGamePrototype game3 = new ConcreteGame(1, "HOI4", "Strategy");

            if (game.Equals(game1))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            if (game.Equals(game2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            if (game.Equals(game3))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }
        }
    }
}
