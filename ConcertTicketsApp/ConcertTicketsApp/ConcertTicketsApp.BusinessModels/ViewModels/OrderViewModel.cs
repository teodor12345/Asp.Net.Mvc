using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTicketsApp.BusinessModels.ViewModels
{
     public class OrderViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public List<TicketViewModel> Tickets { get; set; }
    }
}
