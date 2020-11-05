using ConcertTickets.App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTickets.App.Domain.Models
{
  public  class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public List<TicketOrder> TicketOrders { get; set; }

    }
}
