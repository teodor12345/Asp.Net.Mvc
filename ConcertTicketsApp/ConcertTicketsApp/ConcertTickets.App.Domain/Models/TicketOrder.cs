using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTickets.App.Domain.Models
{
  public  class TicketOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
