using ConcertTickets.App.Domain.Models;
using ConcertTickets.DataAccess.Repositories;
using ConcertTickets.DataAccess.Repositories.CacheRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTicketsApp.BusinessLayer.Helpers
{
    public static class DiModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Ticket>, TicketRepository>();
            services.AddTransient<IRepository<Feedback>, FeedBackRepository>();

            return services;
        }
    }
}
