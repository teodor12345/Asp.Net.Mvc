using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET.Homework01.Controllers
{
    [Route("homework/movie")]
    public class MovieController:Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("get-movies/{id:datetime}")]
        // yyyy-mm-dd
        public IActionResult GetMoviesByDateTime(DateTime datetime)
        {
            datetime = DateTime.Now;

            var Movie = new
            {
                Name = "Fight Club",
                id = datetime
            };

            return Json(Movie);
        }

        [HttpGet("get-available/{id:bool}")]
        public IActionResult GetMovieIfAvailable(bool id)
        {
            var Movie = new
            {
                Name = "Saw",
                Id = id
            };
                  return Json(Movie);
        }
    }
}
