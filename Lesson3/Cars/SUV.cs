using Lesson3.FuelStations;
using Lesson3.WipingStations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Cars
{
    public class SUV : Car, IWiping, IFueling
    {
        public SUV(string model) : base(model) { }


        public double GetCurrentFuelLevel() => FuelLevel;
        public double GetFreeSpace() => FuelTankCapacity - FuelLevel;


        public void SetWipingStation(IGetWiping wipingStation)
        {
            _wipingStation = wipingStation;
            Console.WriteLine($"Выбрана станция мойки. (SUV {Model})");
        }


        public void FreeWipingStation()
        {
            _wipingStation = null;
            Console.WriteLine($"Cтанция мойки освобождена. (SUV {Model})");
        }

        public void WashBody()
        {
            _wipingStation.WashBody();
        }
        public void WashWheels()
        {
            _wipingStation.WashWheels();
        }

        public void WashLights()
        {
            _wipingStation.WashLights();
        }


        public void SetFuelStation(IGetFuel fuelStation)
        {
            _fuelStation = fuelStation;
            Console.WriteLine($"Выбрана заправочная станция. (SUV {Model})");
        }

        public void FreeFuelStation()
        {
            _fuelStation = null;
            Console.WriteLine($"Заправочная станция освобождена. (SUV {Model})");
        }

        public void Fueling(double amount)
        {
            if (_fuelStation == null)
                throw new Exception($"Заправочная станция для SUVа {Model} не выбрана!");
            if (amount > GetFreeSpace())
                throw new Exception($"Запрошенный объем топлива превышает свободный объем! (SUV {Model})");
            Console.WriteLine($"Начинается заправка. (SUV {Model})");
            _fuelStation.Refuel(FuelType, amount);
            Console.WriteLine($"Заправка завершена. (SUV {Model})");
        }

        private IGetWiping _wipingStation;
        private IGetFuel _fuelStation;
    }
}
