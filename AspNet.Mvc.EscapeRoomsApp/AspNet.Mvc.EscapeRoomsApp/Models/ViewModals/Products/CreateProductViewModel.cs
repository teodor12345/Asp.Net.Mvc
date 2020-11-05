using AspNet.Mvc.EscapeRoomsApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomsApp.Models.ViewModals.Products
{
    public class CreateProductViewModel
        
    {

        public int Id { get; set; }
        [Display(Name = "Name of the Room")]
        public string Name { get; set; }
        [Display(Name = "Describe it")]
        public string Description { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "What kind of Category")]
        public Category Category { get; set; }
    }
}
