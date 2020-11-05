using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConcertTickets.Application.Models;
using ConcertTicketsApp.BusinessLayer.Interfaces;
using ConcertTicketsApp.BusinessModels.ViewModels;

namespace ConcertTickets.Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITicketOrderService _ticketOrderService;
        private readonly IUserService _userService;

        public HomeController(ITicketOrderService ticketOrderService,
            IUserService userService)
        {
            _ticketOrderService = ticketOrderService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            return RedirectToAction("Order", "Order", new { tickets = model.NumberOfTickets });
        }

        [HttpGet]
        public IActionResult Menu()
        {
            var menu = _ticketOrderService.GetMenu();
            return View(menu);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Feedback()
        {
            return View(new FeedbackViewModel());
        }

        [HttpPost]
        public IActionResult Feedback(FeedbackViewModel model)
        {
            _userService.GiveFeedback(model);
            return RedirectToAction("Index");
        }
    }
}
