using Lesson4.Models.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Servises.TicketProvider
{
    internal class TicketProvider : ITicketProvider
    {
        private List<ITicket> _ticketsRepo = [];

        public ITicket CreateTicket(int userId, int place, decimal price, int routeNumber)
        {
            ITicket ticket = new Ticket(userId, place, price, routeNumber);
            _ticketsRepo.Add(ticket);
            return ticket;
        }

        public void DeleteTicket(int id)
        {
            foreach (ITicket ticket in _ticketsRepo)
            {
                if (ticket.GetId() == id)
                {
                    _ticketsRepo.Remove(ticket);
                    return;
                }
            }
        }

        public ITicket GetTicket(int id)
        {
            foreach (ITicket ticket in _ticketsRepo)
            {
                if (ticket.GetId() == id)
                    return ticket;
            }
            throw new ArgumentOutOfRangeException();
        }

        public List<ITicket> GetTickets()=>_ticketsRepo.ToList();
        

        public List<ITicket> GetTicketsByUser(int userId)
        {
            List < ITicket > tickets = new List<ITicket>();
            foreach (ITicket ticket in _ticketsRepo)
            {
                if (ticket.GetUserId() == userId)
                    tickets.Add(ticket);
            }
            return tickets;
        }
    }
}
