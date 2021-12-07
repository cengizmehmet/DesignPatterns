using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            RemoteController remoteController = new RemoteController(new LightOnCommand(light), new LightOffCommand(light));
            remoteController.ClickOn();
            remoteController.ClickOff();
        }
    }
}
