using SparkDotnet8.Application.Models;
using Coravel.Events.Interfaces;

namespace SparkDotnet8.Application.Events;


public class UserCreated : IEvent
{
    public User User { get; set; }

    public UserCreated(User user)
    {
        this.User = user;
    }
}
