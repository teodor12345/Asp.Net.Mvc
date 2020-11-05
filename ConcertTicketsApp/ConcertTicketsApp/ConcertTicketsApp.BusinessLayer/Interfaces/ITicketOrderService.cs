using ConcertTicketsApp.BusinessModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTicketsApp.BusinessLayer.Interfaces
{
  public  interface ITicketOrderService
    {
        OrdersViewModel GetAllOrders();
        MenuViewModel GetMenu();
        string GetMostPopularTicket();
        OrderDetailsViewModel GetOrderById(int id);
        int MakeNewOrder(OrderViewModel orderVm);
    }
}
