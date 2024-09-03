using Lesson4.Servises.CashProvider;
using Lesson4.Servises.TicketProvider;
using Lesson4.Servises.UserProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Customer
{
    internal interface ICustomer
    {
        public IUserProvider GetUserProvider();
        public ITicketProvider GetTicketProvider();
        public ICashProvider GetCashProvider();

        public void PrintUsers();
        public void PrintTickets();
        public void PrintCashOperations();
    }
}
