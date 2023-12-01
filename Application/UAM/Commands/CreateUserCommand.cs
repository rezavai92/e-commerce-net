using Domain.Models;
using Application.shared.Interfaces;

namespace Application.UAM.Commands
{
    public sealed record CreateUserCommand (
        string FirstName,
        string LastName,
        string Email,
        Address? Address,
        string Password,
        DateOnly DateOfBirth,
        string? PhoneNumber
        ) : ICommand ;
}
