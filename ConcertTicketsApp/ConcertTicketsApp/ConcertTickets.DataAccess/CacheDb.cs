using ConcertTickets.App.Domain.Enums;
using ConcertTickets.App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTickets.DataAccess
{
   public class CacheDb
    {
        public static List<Order> Orders;
        public static List<User> Users;
        public static List<Ticket> ListOfConcertTickets;
        public static List<Feedback> Feedbacks;
        public static int OrderId;
        public static int UserId;
        public static int TicketId;
        public static int FeedbackId;
        static CacheDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Viktorija",
                    LastName = "Jovanovska",
                    Address = "5th Avenue",
                    Phone = 0805
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Nikola",
                    LastName = "Jovanovski",
                    Address = "12th Avenue",
                    Phone = 08544445
                }
            };
            ListOfConcertTickets = new List<Ticket>()
            {
                new Ticket()
                {
                    Id = 1,
                    Name = "Red Hot",
                    Price = 17,
                    Category = Category.Rock,
                    Image = "red.png"
                },
                  new Ticket()
                {
                    Id = 2,
                    Name = "The Lumineers",
                    Price = 22,
                    Category = Category.Alternative,
                    Image = "lum.png"
                },
                  new Ticket()
                {
                    Id = 3,
                    Name = "Dua Lipa",
                    Price = 10,
                    Category = Category.Pop,
                    Image = "dua.png"
                },
                 new Ticket()
                {
                    Id = 4,
                    Name = "Green Day",
                    Price = 47,
                    Category = Category.Rock,
                    Image = "download.png"
                },
                 new Ticket()
                {
                    Id = 5,
                    Name = "Eminem",
                    Price = 15,
                    Category = Category.HipHop,
                    Image = "eminem.png"
                },
                 new Ticket()
                {
                    Id = 6,
                    Name = "Post Malone",
                    Price = 33,
                    Category = Category.HipHop,
                    Image = "post.png"
                },
                  new Ticket()
                {
                    Id = 7,
                    Name = "Blondie ",
                    Price = 7,
                    Category = Category.Alternative,
                    Image = "Blondie.png"
                },
              new Ticket()
                {
                    Id = 8,
                    Name = "Lizzo",
                    Price = 77,
                    Category = Category.Pop,
                    Image = "lizzo.png"
                },
                  new Ticket()
                {
                    Id = 9,
                    Name = "Billy Eilish",
                    Price = 7,
                    Category = Category.Pop,
                    Image = "billie.png"
                },
                   new Ticket()
                {
                    Id = 10,
                    Name = "The Killers",
                    Price = 78,
                    Category = Category.Rock,
                    Image = "killers.png"
                },
                 new Ticket()
                {
                    Id = 11,
                    Name = "Migos",
                    Price = 7,
                    Category = Category.HipHop,
                    Image = "migos.png"
                },
                 new Ticket()
                {
                    Id = 12,
                    Name = "Cardi B",
                    Price = 7,
                    Category = Category.HipHop,
                    Image = "cardi.png"
                },
            };
            Orders = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = Users[0],
                    TicketsOrders = new List<TicketOrder>(){
                        new TicketOrder(){ Ticket = ListOfConcertTickets[0] } }
                },
                new Order()
                {
                    Id = 2,
                    User = Users[0],
                    TicketsOrders = new List<TicketOrder>(){
                        new TicketOrder(){ Ticket = ListOfConcertTickets[1] },
                        new TicketOrder(){ Ticket = ListOfConcertTickets[2] },
                        new TicketOrder(){ Ticket = ListOfConcertTickets[4] }}
                },
        
            };
            Feedbacks = new List<Feedback>();
            OrderId = 3;
            UserId = 2;
            TicketId = 12;
            FeedbackId = 0;
        }
    }
}

