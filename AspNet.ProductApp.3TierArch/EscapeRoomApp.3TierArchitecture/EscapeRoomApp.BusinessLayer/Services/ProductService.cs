using EscapeRoom.DataLayer.Interfaces;
using EscapeRoom.DataLayer.Repositories;
using EscapeRoomApp.BusinessLayer.Interfaces;
using EscapeRoomApp.BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscapeRoomApp.BusinessLayer.Services
{
   public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
              _productRepository = new ProductRepository();


        }


        public List<ProductViewModel> GetAllProducts()
        {
            return _productRepository.GetAll()
                .Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
        }
    }
}

