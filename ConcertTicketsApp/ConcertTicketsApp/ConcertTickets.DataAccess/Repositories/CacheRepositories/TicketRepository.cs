using ConcertTickets.App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcertTickets.DataAccess.Repositories.CacheRepositories
{
  public class TicketRepository:IRepository<Ticket>
    {
        public List<Ticket> GetAll()
        {
            return CacheDb.ListOfConcertTickets;
        }

        public Ticket GetById(int id)
        {
            return CacheDb.ListOfConcertTickets.FirstOrDefault(p => p.Id == id);
        }

        public int Insert(Ticket entity)
        {
            CacheDb.TicketId++;
            entity.Id = CacheDb.TicketId;
            CacheDb.ListOfConcertTickets.Add(entity);
            return entity.Id;
        }

        public void Update(Ticket entity)
        {
            var ticket= CacheDb.ListOfConcertTickets.FirstOrDefault(p => p.Id == entity.Id);
            if (ticket != null)
            {
                int index = CacheDb.ListOfConcertTickets.IndexOf(ticket);
                CacheDb.ListOfConcertTickets[index] = entity;
            }
        }

        public void Delete(int id)
        {
            var ticket = CacheDb.ListOfConcertTickets.FirstOrDefault(p => p.Id == id);
            if (ticket != null)
            {
                CacheDb.ListOfConcertTickets.Remove(ticket);
            }
        }
    }
}

