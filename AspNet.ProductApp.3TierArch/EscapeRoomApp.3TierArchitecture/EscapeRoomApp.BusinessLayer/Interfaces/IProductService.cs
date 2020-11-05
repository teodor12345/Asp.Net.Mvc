using EscapeRoomApp.BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoomApp.BusinessLayer.Interfaces
{
   public interface IProductService
    {
        List<ProductViewModel> GetAllProducts();

    }
}
