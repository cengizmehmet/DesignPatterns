using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_WarGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Villager villager1 = new Villager("Villager");
            Villager villager2 = new Villager("Villager");
            LongBow archer1 = new LongBow(villager1, "Archer");
            Pike pikeman1 = new Pike(villager2, "Pikeman");

            Pike p = new Pike(archer1, "D");

            Console.WriteLine(p.Cost());
            Console.WriteLine(p.GetHumanType());
            Console.WriteLine(p.Range());
            Console.WriteLine("---");
            Console.WriteLine(villager1.Cost());
            Console.WriteLine(villager1.GetHumanType());
            Console.WriteLine(villager1.Range());
            Console.WriteLine();
            Console.WriteLine(archer1.Cost());
            Console.WriteLine(archer1.GetHumanType());
            Console.WriteLine(archer1.Range());
            Console.WriteLine();
            Console.WriteLine(villager2.Cost());
            Console.WriteLine(villager2.GetHumanType());
            Console.WriteLine(villager2.Range());
            Console.WriteLine();
            Console.WriteLine(pikeman1.Cost());
            Console.WriteLine(pikeman1.GetHumanType());
            Console.WriteLine(pikeman1.Range());
        }
    }
}
