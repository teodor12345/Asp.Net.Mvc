using ConcertTicketsApp.BusinessModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConcertTicketsApp.BusinessLayer.Interfaces
{
  public  interface IUserService
    {
        string GetLastUsername();
        void GiveFeedback(FeedbackViewModel feedbackVm);
    }
}
