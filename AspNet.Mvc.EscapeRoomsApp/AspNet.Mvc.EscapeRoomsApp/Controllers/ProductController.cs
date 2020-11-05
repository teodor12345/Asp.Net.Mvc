using AspNet.Mvc.EscapeRoomsApp.Models.Domain;
using AspNet.Mvc.EscapeRoomsApp.Models.ViewModals.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomsApp.Controllers
{
    public class OrderController:Controller
    {
        [HttpGet("MoreDetails")]
        [HttpGet("MoreDetails/{id:int}")]
        public IActionResult Index(int id)
        {
            var room =InMemoryDB.Database.EscapeRooms.FirstOrDefault(x => x.Id == id);
            var roomVm = new ProductViewModel
            {
                Id = room.Id,
                Name = room.Name,
                Price = room.Price,
                Category = room.Category,
                Description = room.Description
            };

            return View("MoreDetails", roomVm);
        }



        [HttpGet("CreateProduct")]
        public IActionResult CreateProduct(string error)
        {
            ViewBag.Error = error;
            return View();
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct(CreateProductViewModel createroom)
        {
         
            Product newroom = new Product()
            {
                Id = InMemoryDB.Database.EscapeRooms.Count + 1,
                Name = createroom.Name,
                Category = createroom.Category,
                Price = createroom.Price,
                Description = createroom.Description
            };
            if (newroom.Name == null || newroom.Description == null || newroom.Price == 0)
            {
                return RedirectToAction("CreateProduct", new { error = "Error! Your escape room was not created. Try again" });
            }
            else
            {
                InMemoryDB.Database.EscapeRooms.Add(newroom);
                return View("ProductComplete");
            }



        }
    }
}
