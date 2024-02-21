using Application.shared.Interfaces;
using Application.shared.Models;

namespace Application.Identity.Commands
{
    public class RegisterUserCommand : ICommand<ShopHubResponseModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool RememberMe { get; set; }
    }
}
