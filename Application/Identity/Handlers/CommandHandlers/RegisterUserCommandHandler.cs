using Application.Identity.Commands;
using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Enums;
using Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Net;

namespace Application.Identity.Handlers.CommandHandlers
{
    public class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand, ShopHubResponseModel>
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<ApplicationRole> _roleManager;


        public RegisterUserCommandHandler(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
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
                var found = await _roleManager.FindByNameAsync(nameof(UserRole.AppUser));
                if (found == null) {

                    var applicationRole = new ApplicationRole
                    {
                        Name = nameof(UserRole.AppUser),
                        Id = Guid.NewGuid().ToString(), 
                        
                    };

                    await _roleManager.CreateAsync(applicationRole);
                }
                await _userManager.AddToRoleAsync(user, nameof(UserRole.AppUser));
                await _signInManager.SignInAsync(user, command.RememberMe);
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
