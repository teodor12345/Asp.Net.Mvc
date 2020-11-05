using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET.Homework01.Controllers
{
    [Route("product")]
    public class ProductController :Controller
    {
            [HttpGet]
            public IActionResult Index()
            {
                return View();
            }

            [HttpGet("get-product/{id:int}")]
            public IActionResult GetProductById(int id)
            {
                var Product = new
                {
                    Name = "ProductById",
                    Id = id
                };
                return Json(Product);
            }

            [HttpGet("get-product/{id:alpha}")]
            public IActionResult GetProductByName(string name)
            {
                var Product = new
                {
                    Name = "ProductByName",
                    Id = name
                };
                return Json(Product);
            }
        }
    }

