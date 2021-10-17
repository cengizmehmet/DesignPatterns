using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_CarFactory
{
    class Car
    {
        public EngineFactory engine { get; set; }
        public BodyworkFactory bodywork { get; set; }

        public Car(EngineFactory engine, BodyworkFactory bodywork)
        {
            this.bodywork = bodywork;
            this.engine = engine;
        }
    }
}
