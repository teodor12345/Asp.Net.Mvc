using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTickets.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        int Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
