using Lesson3.WipingStations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Cars
{
    public interface IWiping // Интерфейс мойки
    {
        /// <summary>
        /// Указание на станцию мойки для использования 
        /// </summary>
        void SetWipingStation(IGetWiping wipingStation);

        /// <summary>
        /// Освобождение станцию мойки
        /// </summary>
        void FreeWipingStation();

        void WashBody();
        void WashWheels();
        void WashLights();
    }
}
