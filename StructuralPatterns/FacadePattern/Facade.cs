using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_CarFactory
{
    class Facade
    {
        EngineFactory engine;
        BodyworkFactory bodywork;
        CarFactory carFactory;

        public Facade(Enumerators.Colors color, int hp)
        {
            engine = new EngineFactory(hp);
            bodywork = new BodyworkFactory(engine, color);
            carFactory = new CarFactory(engine, bodywork);
        }

        public Car GetCar()
        {
            return new Car(engine, bodywork);
        }
    }
}
