using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.FuelStations
{
    public class DieselStation : FuelStation, IGetFuel
    {
        public DieselStation(string name):base(name, EFuelType.Diesel)
        {
            
        }

        public void Refuel(EFuelType fuelType, double amount)
        {
            if (fuelType != FuelType)
                throw new Exception("Заправочная станция не может предоставить данный вид топлива!");
            if (amount < 0)
                throw new Exception("Объем топлива должен быть > 0!");
            if(amount > FuelLevel)
                throw new Exception("Недостаточно топлива!");
            RemoveFuel(amount);
            Console.WriteLine($"Заправочная станция {Name}: Дизельное топливо {amount} литров заправлено!");
        }
    }
}
