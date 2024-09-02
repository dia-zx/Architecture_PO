using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models.Ticket
{
    internal class Ticket : ITicket
    {
        private static int nextID = 1000;

        public Ticket(int userId, int place, decimal price, int routeNumber)
        {
            _Id = nextID++;
            _userId = userId;
            _Date = DateTime.Now;
            _RouteNumber = routeNumber;
        }

        public DateTime GetDate() => _Date;

        public int GetId() => _Id;

        public int GetPlace() => _place;

        public decimal GetPrice() => _price;

        public int GetRouteNumber() => _RouteNumber;

        public bool GetValid() => _isValid;

        public void Print() =>  Console.WriteLine(ToString());
        

        public void SetValid(bool valid) => _isValid = valid;

        public override string ToString()
        {
            string line = $"* Билет ID: {_Id}, приобретен: {_Date}, на маршрут: {_RouteNumber}, место: {_place}, по цене: {_price}";
            if (_isValid)
                return line + " действует!";
            else
                return line + " не действует!";
        }

        public int GetUserId() => _userId;

        private int _Id;
        private int _userId;
        private DateTime _Date;
        private int _place;
        private decimal _price;
        private int _RouteNumber;
        private bool _isValid = true;
    }
}
