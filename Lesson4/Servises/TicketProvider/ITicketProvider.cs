using Lesson4.Models.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Servises.TicketProvider
{
    internal interface ITicketProvider
    {
        public ITicket CreateTicket(int userId, int place, decimal price, int routeNumber);
        public List<ITicket> GetTicketsByUser(int userId);
        public List<ITicket> GetTickets();
        public void DeleteTicket(int id);
        public ITicket GetTicket(int id);
    }
}
