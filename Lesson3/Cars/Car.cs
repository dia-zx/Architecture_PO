using Lesson3.FuelStations;
using Lesson3.WipingStations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Cars
{
    public abstract class Car
    {
        public string Model { get; set; }
        public double FuelLevel { get; private set; }
        public double FuelTankCapacity { get; } = 50; // Объем бака в литрах
        public EFuelType FuelType { get; set; }

        public Car(string model)
        {
            Model = model;
            FuelLevel = 0;
            FuelType = EFuelType.Petrol;
        }


        protected void AddFuel(double amount)
        {
            if (FuelLevel + amount <= FuelTankCapacity)
                FuelLevel += amount;
        }
    }

}
