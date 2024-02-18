using Application.shared.Interfaces;
using Domain.Entities;

namespace Application.UAM.Commands
{
    public sealed record CreateUserCommand (
        string FirstName,
        string LastName,
        string Email,
        Location? Address,
        string Password,
        DateOnly DateOfBirth,
        string? PhoneNumber
        ) : ICommand ;
}
