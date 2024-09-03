using Lesson4.Models.Ticket;
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
    internal class Customer : ICustomer
    {
        private ICashProvider _cashProvider;
        private ITicketProvider _ticketProvider;
        private IUserProvider _userProvider;

        public Customer() {
            _cashProvider = new CashProvider(2345345);
            _ticketProvider = new TicketProvider();
            _userProvider = new UserProvider();
        }

        public ICashProvider GetCashProvider() => _cashProvider;


        public ITicketProvider GetTicketProvider() => _ticketProvider;
        

        public IUserProvider GetUserProvider()=> _userProvider;

        public void PrintCashOperations()
        {
            foreach (var operation in _cashProvider.GetOperations())
            {
                Console.WriteLine(operation);
            }
        }

        public void PrintTickets()
        {
            foreach (var ticket in _ticketProvider.GetTickets())
            {
                Console.WriteLine(ticket);
            }
        }

        public void PrintUsers()
        {
            foreach (var user in _userProvider.GetUsers())
            {
                Console.WriteLine(user);
            }
        }
    }
}
