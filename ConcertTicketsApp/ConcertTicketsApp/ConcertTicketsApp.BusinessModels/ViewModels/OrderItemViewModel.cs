using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTicketsApp.BusinessModels.ViewModels
{
  public  class OrderItemViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Price { get; set; }
        public List<TicketViewModel> Tickets { get; set; } = new List<TicketViewModel>();
    }
}
