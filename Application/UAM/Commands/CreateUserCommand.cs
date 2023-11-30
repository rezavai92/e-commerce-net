using Domain.Models;
using Application.shared.Interfaces;

namespace Application.UAM.Commands
{
    public sealed record CreateUserCommand (
        string FirstName,
        string LastName, 
        Address Address,
        string Password,
        DateTime DateOfBirth,
        string PhoneNumber
        ) : ICommand ;
}
