using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNet.Mvc.EscapeRoomsApp.Models;
using AspNet.Mvc.EscapeRoomsApp.Models.ViewModals.Products;
using AspNet.Mvc.EscapeRoomsApp.Models.Domain;

namespace AspNet.Mvc.EscapeRoomsApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ProductViewModel escapeRoomVm = new ProductViewModel();
            List<ProductViewModel> escapeRoomsListVM = new List<ProductViewModel>();


            foreach (Product room in InMemoryDB.Database.EscapeRooms)
            {
                escapeRoomVm = new ProductViewModel()
                {
                    Id = room.Id,
                    Name = room.Name,
                    Price = room.Price
                };
                escapeRoomsListVM.Add(escapeRoomVm);
            }


            ProductListViewModel escapeRoomsList = new ProductListViewModel()
            {
                TotalNumberOfRooms = InMemoryDB.Database.EscapeRooms.Count,
                EscapeRooms = escapeRoomsListVM
            };

            return View("Index", escapeRoomsList);
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
