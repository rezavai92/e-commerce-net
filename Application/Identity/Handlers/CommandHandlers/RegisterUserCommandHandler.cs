using Application.Identity.Commands;
using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Net;

namespace Application.Identity.Handlers.CommandHandlers
{
    public class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand, ShopHubResponseModel>
    {
        private UserManager<ApplicationUser> _userManager;



        public RegisterUserCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ShopHubResponseModel> Handle(RegisterUserCommand command, CancellationToken cancellationToken)
        {

            var response = new ShopHubResponseModel();

            var user = new ApplicationUser
            {
                UserName = command.LastName + Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,

            };


            var result = await _userManager.CreateAsync(user, command.Password);

            if (result.Succeeded)
            {
                response.SetSuccess(HttpStatusCode.Created, "User created successfully");
            }
            else
            {
                response.SetError(HttpStatusCode.BadRequest, JsonConvert.SerializeObject(result.Errors));

            }


            return response;
        }
    }
}
