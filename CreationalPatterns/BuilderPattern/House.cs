using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class House : IHousePlan
    {
        private string basement;
        private string structure;
        private string roof;
        private string interior;

        public void Basement(string basement)
        {
            this.basement = basement;
        }

        public void Structure(string structure)
        {
            this.structure = structure;
        }

        public void Roof(string roof)
        {
            this.roof = roof;
        }

        public void Interior(string interior)
        {
            this.interior = interior;
        }
    }
}
