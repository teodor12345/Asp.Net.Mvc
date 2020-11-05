using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTicketsApp.BusinessModels.ViewModels
{
 public class OrderDetailsViewModel
    {
        public string Address { get; set; }
        public long Phone { get; set; }
        public OrderItemViewModel Order { get; set; }
    }
}
