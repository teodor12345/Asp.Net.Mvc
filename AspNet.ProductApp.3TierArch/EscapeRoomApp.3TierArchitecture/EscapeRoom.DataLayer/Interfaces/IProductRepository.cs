using EscapeRoom.DataLayer.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom.DataLayer.Interfaces
{
  public  interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Insert(Product entity);
        void Update(Product entity);
        int Remove(Product entity);
    }
}
