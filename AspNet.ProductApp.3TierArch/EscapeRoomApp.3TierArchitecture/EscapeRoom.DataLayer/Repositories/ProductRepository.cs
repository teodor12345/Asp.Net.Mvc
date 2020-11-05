using EscapeRoom.DataLayer.DomainModels;
using EscapeRoom.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoom.DataLayer.Repositories
{
   public class ProductRepository:IProductRepository
    {
        private Database _db;

            public ProductRepository()
            {
                _db = new Database();
            }
            public List<Product> GetAll()
            {
            return Database.EscapeRooms;
            }

            public void Insert(Product entity)
            {
                throw new NotImplementedException();
            }

            public int Remove(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }

        Product IProductRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
