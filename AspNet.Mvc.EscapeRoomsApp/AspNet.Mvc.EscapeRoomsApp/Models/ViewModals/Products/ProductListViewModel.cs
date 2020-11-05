using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Mvc.EscapeRoomsApp.Models.ViewModals.Products
{
    public class ProductListViewModel
    {
        public int TotalNumberOfRooms { get; set; }
        public List<ProductViewModel> EscapeRooms { get; set; }

    }
}
