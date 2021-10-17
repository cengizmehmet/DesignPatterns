using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeSoldier general = new CompositeSoldier("gen", Enumerators.Ranks.General);

            general.AddSoldier(new LeafSoldier("col1", Enumerators.Ranks.Colonel));
            general.AddSoldier(new LeafSoldier("col2", Enumerators.Ranks.Colonel));

            CompositeSoldier colonel = new CompositeSoldier("col3", Enumerators.Ranks.Colonel);

            CompositeSoldier major = new CompositeSoldier("maj1", Enumerators.Ranks.Major);

            major.AddSoldier(new LeafSoldier("cap1", Enumerators.Ranks.Captain));
            colonel.AddSoldier(major);
            colonel.AddSoldier(new LeafSoldier("maj2", Enumerators.Ranks.Major));

            general.AddSoldier(colonel);

            general.ExecuteOrder(1);
        }
    }
}
