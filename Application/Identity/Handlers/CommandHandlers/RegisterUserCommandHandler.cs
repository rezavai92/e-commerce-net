using Application.Identity.Commands;
using Application.shared.Interfaces;
using Application.shared.Models;
using Core.Shared.Interfaces;
using Domain.Enums;
using Domain.IdentityEntities;
using Microsoft.AspNetCore.Http;
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
        private IJwtService _jwtService;
        private IPlatformLogger<RegisterUserCommandHandler> _logger;

        public RegisterUserCommandHandler(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService, IPlatformLogger<RegisterUserCommandHandler> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _jwtService = jwtService;
            _logger = logger;
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

            var token = _jwtService.GenerateJwtToken(user);
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

                // Generate JWT and attach with the response 

              
             

                response.SetSuccess(token);
            }
            else
            {
                _logger.LogError(JsonConvert.SerializeObject(result.Errors));
                response.SetError(HttpStatusCode.BadRequest, "Something went wrong");

            }


            return response;
        }
    }
}
