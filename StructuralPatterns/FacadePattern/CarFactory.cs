using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_CarFactory
{
    class CarFactory
    {
        public EngineFactory engine { get; set; }
        public BodyworkFactory bodywork { get; set; }

        public CarFactory(EngineFactory engine, BodyworkFactory bodywork)
        {
            this.engine = engine;
            this.bodywork = bodywork;
        }

        public Car CreateCar()
        {
            return new Car(this.engine, this.bodywork);
        }
    }
}
