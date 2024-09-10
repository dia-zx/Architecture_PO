using Lesson3.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.WipingStations
{
    public interface IGetWiping // Интерфейс мойки
    {
        void WashBody();
        void WashWheels();
        void WashLights();
    }
}
