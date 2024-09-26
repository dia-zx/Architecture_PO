using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Models.Ticket
{
    interface ITicket
    {
        public int GetId();
        public int GetUserId();
        public int GetRouteNumber();
        public int GetPlace();
        public decimal GetPrice();
        public DateTime GetDate();
        public bool GetValid();
        public void SetValid(bool valid);
        public void Print();
    }
}
