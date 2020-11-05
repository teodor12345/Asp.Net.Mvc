using ConcertTickets.App.Domain.Enums;
using ConcertTickets.App.Domain.Models;
using ConcertTickets.DataAccess.Repositories;
using ConcertTicketsApp.BusinessLayer.Interfaces;
using ConcertTicketsApp.BusinessModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcertTicketsApp.BusinessLayer.Services
{
    public class TicketOrderService : ITicketOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<Ticket> _ticketRepository;
        private readonly IRepository<User> _userRepository;

        public TicketOrderService(IRepository<Order> orderRepository,
            IRepository<Ticket> ticketRepository,
            IRepository<User> userRepository)
        {
            _orderRepository = orderRepository;
            _ticketRepository = ticketRepository;
            _userRepository = userRepository;
        }

        public OrdersViewModel GetAllOrders()
        {
            // Domain models
            List<Order> orders = _orderRepository.GetAll();
            // View Models
            // MAPPINT SECTION
            List<OrderItemViewModel> viewOrders = new List<OrderItemViewModel>();
            foreach (Order order in orders)
            {
                List<TicketViewModel> ticketsView = new List<TicketViewModel>();
                foreach (var ticketOrder in order.TicketsOrders)
                {
                    ticketsView.Add(new TicketViewModel()
                    {
                        Id = ticketOrder.Ticket.Id,
                        Image = ticketOrder.Ticket.Image,
                        Name = ticketOrder.Ticket.Name,
                        Price = ticketOrder.Ticket.Price,
                        Category = ticketOrder.Ticket.Category
                    });
                };
                viewOrders.Add(new OrderItemViewModel()
                {
                    FirstName = order.User.FirstName,
                    LastName = order.User.LastName,
                    Id = order.Id,
                    Price = order.Price,
                    Tickets = ticketsView
                });
            }

            var lastUser = _userRepository.GetAll().LastOrDefault();

            OrdersViewModel model = new OrdersViewModel()
            {
                LastTicket = GetLastOrder().TicketsOrders[0].Ticket.Name,
                MostPopularTicket = GetMostPopularTicket(),
                NameOfFirstCustomer = string.Format("{0} {1}", lastUser.FirstName, lastUser.LastName), // $"{lastUser.FirstName} {lastUser.LastName}";
                OrderCount = GetOrderCount(),
                Orders = viewOrders
            };
            return model;
            // We send mapped view model to the view
        }

        public MenuViewModel GetMenu()
        {
            var menu = _ticketRepository.GetAll()
                .GroupBy(p => p.Name)
                .Select(x => x.First())
                .ToList();

            List<TicketViewModel> listOfTickets = new List<TicketViewModel>();
            foreach (var ticket in menu)
            {
                listOfTickets.Add(new TicketViewModel
                {
                    Id = ticket.Id,
                    Image = ticket.Image,
                    Name = ticket.Name,
                    Price = ticket.Price,
                    Category = ticket.Category
                });
            }
            var model = new MenuViewModel
            {
                Menu = listOfTickets
            };

            return model;
        }

        public string GetMostPopularTicket()
        {
            var orders = _orderRepository.GetAll();

            var tickets = orders
                .SelectMany(x => x.TicketsOrders)
                .ToList();

            var mostPopularTicket = tickets
                .GroupBy(x => x.Ticket.Name)
                .OrderByDescending(x => x.Count())
                .FirstOrDefault()
                .Select(x => x.Ticket.Name)
                .FirstOrDefault();

            return mostPopularTicket;
        }

        public OrderDetailsViewModel GetOrderById(int id)
        {
            Order order = _orderRepository.GetById(id);

            if (order == null)
            {
                throw new Exception();
            }

            List<TicketViewModel> tickets = new List<TicketViewModel>();
            foreach (TicketOrder ticketOrder in order.TicketsOrders)
            {
                tickets.Add(new TicketViewModel()
                {
                    Image = ticketOrder.Ticket.Image,
                    Name = ticketOrder.Ticket.Name,
                    Price = ticketOrder.Ticket.Price,
                    Category = ticketOrder.Ticket.Category
                });
            }

            OrderDetailsViewModel viewModel = new OrderDetailsViewModel()
            {
                Address = order.User.Address,
                Order = new OrderItemViewModel()
                {
                    Id = order.Id,
                    FirstName = order.User.FirstName,
                    Tickets = tickets,
                    LastName = order.User.LastName,
                    Price = order.Price
                },
                Phone = order.User.Phone
            };

            return viewModel;
        }

        public int MakeNewOrder(OrderViewModel orderVm)
        {
            var order = new Order();
            var tickets = new List<TicketOrder>();

            foreach (var ticketVm in orderVm.Tickets)
            {
                var ticketOrder = new TicketOrder()
                {
                    Ticket = GetTicketFromList(ticketVm.Name, ticketVm.Category),
                    Order = order
                };
                ticketOrder.TicketId = ticketOrder.Ticket.Id;
                tickets.Add(ticketOrder);
            }

            var user = new User
            {
                Address = orderVm.Address,
                FirstName = orderVm.FirstName,
                LastName = orderVm.LastName,
                Phone = orderVm.Phone
            };

            order.TicketsOrders = tickets;
            order.User = user;
            return _orderRepository.Insert(order);
        }

        private int GetOrderCount()
        {
            return _orderRepository.GetAll().Count;
        }

        private Order GetLastOrder()
        {
            var orders = _orderRepository.GetAll();
            return orders[orders.Count - 1];
        }

        private Ticket GetTicketFromList(string name, Category category)
        {
            return _ticketRepository.GetAll().FirstOrDefault(p => p.Name == name && p.Category == category);
        }
    }
}
