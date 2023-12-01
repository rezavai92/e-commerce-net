using Application.shared.Interfaces;
using Application.shared.Models;
using Application.UAM.Commands;
using Application.UAM.Interfaces;
using FluentValidation;

namespace Application.UAM.Handlers.CommandHandlers
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private IUamService _uamService;
        private IValidator<CreateUserCommand> _validator;
        public CreateUserCommandHandler(IUamService uamService, IValidator<CreateUserCommand> validator)
        {
            _uamService = uamService;
            _validator = validator;
        }

        public async Task<ShopHubResponseModel> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            var response = new ShopHubResponseModel();
            try
            {
                var validationResult = await _validator.ValidateAsync(command);

                if (!validationResult.IsValid)
                {
                    response.SetError(System.Net.HttpStatusCode.BadRequest);
                    return response;
                }

                return await _uamService.CreateUserAsync(command);
            }
            catch(Exception ex)
            {
               
                response.SetError();
                return response;
            }
            
        }
    }
}
