using ConcertTicketsApp.BusinessLayer.Interfaces;
using ConcertTicketsApp.BusinessModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConcertTickets.Application.Controllers
{
    public class OrderController:Controller
    {
        private readonly ITicketOrderService _ticketOrderService;

        public OrderController(ITicketOrderService ticketOrderService)
        {
            _ticketOrderService = ticketOrderService;
        }

        [HttpGet("Orders")]
        public IActionResult Index()
        {
            var orderVm = _ticketOrderService.GetAllOrders();
            return View(orderVm);
        }

        [HttpGet]
        public IActionResult Order(string error, int tickets)
        {
            if (error != null)
            {
                return View("_Error");
            }

            var orderVM = new OrderViewModel();
            orderVM.Tickets= new List<TicketViewModel>();
            for (int i = 0; i < tickets; i++)
            {
                orderVM.Tickets.Add(new TicketViewModel());
            }

            return View(orderVM);
        }

        [HttpPost]
        public IActionResult Order(OrderViewModel model)
        {
            var orderId = _ticketOrderService.MakeNewOrder(model);

            if (orderId != 0)
            {
                return View("_ThankYou");
            }

            return RedirectToAction("Order", model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            try
            {
                var orderDetails = _ticketOrderService.GetOrderById(id);
                return View(orderDetails);
            }
            catch (Exception)
            {
                return View("_Error");
            }
        }
    }
}
