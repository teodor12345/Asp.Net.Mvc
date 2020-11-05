using ConcertTickets.App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcertTickets.DataAccess.Repositories.CacheRepositories
{
    public class FeedBackRepository:IRepository<Feedback>
    {
        public void Delete(int id)
        {
            Feedback feedback = CacheDb.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedback != null)
            {
                CacheDb.Feedbacks.Remove(feedback);
            }
        }

        public List<Feedback> GetAll()
        {
            return CacheDb.Feedbacks;
        }

        public Feedback GetById(int id)
        {
            return CacheDb.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Feedback entity)
        {
            CacheDb.FeedbackId++;
            entity.Id = CacheDb.FeedbackId;
            CacheDb.Feedbacks.Add(entity);
            return entity.Id;
        }

        public void Update(Feedback entity)
        {
            Feedback feedback = CacheDb.Feedbacks.FirstOrDefault(x => x.Id == entity.Id);
            if (feedback != null)
            {
                int index = CacheDb.Feedbacks.IndexOf(feedback);
                CacheDb.Feedbacks[index] = entity;
            }
        }
    }
}

