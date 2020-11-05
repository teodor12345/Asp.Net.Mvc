using ConcertTickets.App.Domain.Models;
using ConcertTickets.DataAccess.Repositories;
using ConcertTicketsApp.BusinessLayer.Interfaces;
using ConcertTicketsApp.BusinessModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcertTicketsApp.BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Feedback> _feedbackRepository;

        public UserService(IRepository<User> userRepository,
            IRepository<Feedback> feedbackRepository)
        {
            _userRepository = userRepository;
            _feedbackRepository = feedbackRepository;
        }

        public string GetLastUsername()
        {
            return _userRepository.GetAll().LastOrDefault().FirstName;
        }

        public void GiveFeedback(FeedbackViewModel feedbackVm)
        {
            Feedback feedback = new Feedback()
            {
                Email = feedbackVm.Email,
                Message = feedbackVm.Message,
                Name = feedbackVm.Name
            };
            _feedbackRepository.Insert(feedback);
        }
    }
}
