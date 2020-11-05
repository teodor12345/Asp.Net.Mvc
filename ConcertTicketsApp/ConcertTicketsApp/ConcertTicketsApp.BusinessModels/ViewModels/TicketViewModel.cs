using ConcertTickets.App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTicketsApp.BusinessModels.ViewModels
{
  public  class TicketViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public string Image { get; set; }
    }
}
