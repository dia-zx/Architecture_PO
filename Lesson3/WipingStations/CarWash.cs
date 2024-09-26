using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.WipingStations
{
    public class CarWash : WipingStation, IGetWiping
    {
        public CarWash(string name) : base(name)
        {
        }

        public void WashBody()
        {
            Console.WriteLine($"Моечная станция CarWash {Name}: Кузов помыт!");
        }

        public void WashLights()
        {
            Console.WriteLine($"Моечная станция CarWash {Name}: Фары помыты!");
        }

        public void WashWheels()
        {
            Console.WriteLine($"Моечная станция CarWash {Name}: Колеса помыты!");
        }
    }
}
