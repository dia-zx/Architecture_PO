using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.FuelStations
{
    // Базовый абстрактный класс FuelStation для заправочных станций
    public abstract class FuelStation
    {
        protected FuelStation(string name, EFuelType fuelType)
        {
            FuelType = fuelType;
            Name = name;
        }

        public string Name { get; set; }
        public double FuelLevel { get; protected set; } = 0;
        public EFuelType FuelType { get; set; }
        public void AddFuel(double amount) => FuelLevel += amount;
        public void RemoveFuel(double amount) => FuelLevel -= amount;
    }
}
