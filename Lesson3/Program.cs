using Lesson3.Cars;
using Lesson3.FuelStations;
using Lesson3.WipingStations;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car sportCar = new SportCar("Porsche");
            Car suv = new SUV("BMW");
            suv.FuelType = EFuelType.Diesel;

            FuelStation petrolStation = new PetrolStation("Лукойл");
            petrolStation.AddFuel(1000);
            FuelStation dieselStation = new DieselStation("СургутНефть");
            dieselStation.AddFuel(1000);

            WipingStation carWash = new CarWash("Мойдодыр");
            WipingStation quickWash = new QuickWash("ТурбоЧист");

            #region Заправка спорткара
            ((IFueling)sportCar).SetFuelStation((IGetFuel)petrolStation);
            ((IFueling)sportCar).Fueling(20);
            ((IFueling)sportCar).FreeFuelStation();
            #endregion

            #region Заправка SUV внедорожника
            ((IFueling)suv).SetFuelStation((IGetFuel)dieselStation);
            ((IFueling)suv).Fueling(20);
            ((IFueling)suv).FreeFuelStation();
            #endregion

            #region Мойка спорткара обычная
            ((IWiping)sportCar).SetWipingStation((IGetWiping)carWash);
            ((IWiping)sportCar).WashLights();
            ((IWiping)sportCar).WashWheels();
            ((IWiping)sportCar).WashBody();
            ((IWiping)sportCar).FreeWipingStation();
            #endregion

            #region Мойка SUV внедорожника быстрая
            ((IWiping)sportCar).SetWipingStation((IGetWiping)quickWash);
            ((IWiping)sportCar).WashLights();
            ((IWiping)sportCar).WashWheels();
            ((IWiping)sportCar).WashBody();
            ((IWiping)sportCar).FreeWipingStation();
            #endregion
        }
    }
}
