using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.FuelStations
{
    // Конкретная реализация заправочной станции
    public class PetrolStation : FuelStation, IGetFuel
    {
        public PetrolStation(string name) : base(name, EFuelType.Petrol)
        {

        }

        public void Refuel(EFuelType fuelType, double amount)
        {
            if (fuelType != FuelType)
                throw new Exception("Заправочная станция не может предоставить данный вид топлива!");
            if (amount < 0)
                throw new Exception("Объем топлива должен быть > 0!");
            if (amount > FuelLevel)
                throw new Exception("Недостаточно топлива!");
            RemoveFuel(amount);
            Console.WriteLine($"Заправочная станция {Name}: {amount} литров бензина заправлено!");
        }
    }
}
