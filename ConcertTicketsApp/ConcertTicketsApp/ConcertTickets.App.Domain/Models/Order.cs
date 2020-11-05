using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcertTickets.App.Domain.Models
{
  public  class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

        public List<TicketOrder> TicketsOrders { get; set; } = new List<TicketOrder>();

        public double Price
        {
            get
            {
                return TicketsOrders.Sum(o => o.Ticket.Price) + 2;
            }
        }
    }
}
