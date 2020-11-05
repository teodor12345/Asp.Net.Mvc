using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTicketsApp.BusinessModels.ViewModels
{
  public  class OrdersViewModel
    {
        public List<OrderItemViewModel> Orders { get; set; }
        public int OrderCount { get; set; }
        public string LastTicket { get; set; }
        public string MostPopularTicket { get; set; }
        public string NameOfFirstCustomer { get; set; }
    }
}
