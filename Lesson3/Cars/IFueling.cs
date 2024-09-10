using Lesson3.FuelStations;
using Lesson3.WipingStations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IFueling // Интерфейс заправки
{
    /// <summary>
    /// Указание на станцию мойки для использования 
    /// </summary>
    void SetFuelStation(IGetFuel fuelStation);

    /// <summary>
    /// Освобождение станцию мойки
    /// </summary>
    void FreeFuelStation();

    double GetCurrentFuelLevel();
    double GetFreeSpace();
    void Fueling(double amount);
}
