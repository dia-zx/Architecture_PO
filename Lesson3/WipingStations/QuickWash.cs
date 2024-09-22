using Lesson3.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.WipingStations
{
    public class QuickWash : WipingStation, IGetWiping
    {
        public QuickWash(string name) : base(name)
        {
        }

        public void WashBody()
        {
            Console.WriteLine($"Моечная станция QuickWash {Name}: Кузов помыт!");
        }

        public void WashLights()
        {
            Console.WriteLine($"Моечная станция QuickWash {Name}: Фары помыты!");
        }

        public void WashWheels()
        {
            Console.WriteLine($"Моечная станция QuickWash {Name}: Колеса помыты!");
        }
    }
}
