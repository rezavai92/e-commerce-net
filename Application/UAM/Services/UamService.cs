using Application.shared.Models;
using Application.UAM.Commands;
using Application.UAM.Interfaces;

namespace Application.UAM.Services
{
    internal class UamService : IUamService
    {
        public async Task<ServiceResponse> CreateUserAsync(CreateUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
