using Application.shared.Interfaces;
using Application.shared.Models;
using Application.UAM.Commands;
using Application.UAM.Interfaces;

namespace Application.UAM.Handlers.CommandHandlers
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private IUamService _uamService;
        public CreateUserCommandHandler(IUamService uamService)
        {
            _uamService = uamService;
        }

        public async Task<ServiceResponse> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            return await _uamService.CreateUserAsync(command);
        }
    }
}
