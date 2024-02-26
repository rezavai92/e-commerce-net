using Application.Identity.Commands;
using Application.Identity.Dtos;
using Application.shared.Interfaces;
using Application.shared.Models;
using Core.Shared.Interfaces;
using Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;

namespace Application.Identity.Handlers.CommandHandlers
{
    public class LoginUserCommandHandler : ICommandHandler<LoginUserCommand, ShopHubResponseModel>
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private RoleManager<ApplicationRole> _roleManager;
        private IJwtService _jwtService;
        public LoginUserCommandHandler(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, IJwtService jwtService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _jwtService = jwtService;
        }

        public async Task<ShopHubResponseModel> Handle(LoginUserCommand command, CancellationToken cancellationToken)
        {
            var response = new ShopHubResponseModel();
            try
            {

                var foundUser = await _userManager.FindByEmailAsync(command.Email);

                if (foundUser == null)
                {
                    return response.SetError(System.Net.HttpStatusCode.BadRequest, "Unauthenticated user");
                }

                var res = await _signInManager.PasswordSignInAsync(foundUser, command.Password, true, false);

                if (res.Succeeded)
                {
                    // generate JWT TOKEN
                    // attach jwt token to response

                    var jwtToken = _jwtService.GenerateJwtToken(foundUser);

                    var roles = await _userManager.GetRolesAsync(foundUser);

                    var loginResponseDto = new LoginResponseDto
                    {
                        DisplayName = foundUser.FirstName + " " + foundUser.LastName,
                        Email = foundUser.Email,
                        ProfileImageUrl = foundUser.ProfileImageUrl,
                        Token = jwtToken,
                        UserRoles = roles.ToList()
                    };

                    return response.SetSuccess(loginResponseDto);
                }

                response.SetError();
            }
            catch (Exception ex)
            {

                response.SetError(System.Net.HttpStatusCode.InternalServerError, "Something went wrong");
            }

            return response;

        }
    }
}
