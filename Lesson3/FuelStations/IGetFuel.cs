using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.FuelStations
{
    public interface IGetFuel // Интерфейс заправки
    {
        void Refuel(EFuelType fuelType, double amount);
    }
}
