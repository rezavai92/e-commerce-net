using Application.shared.Interfaces;
using Application.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Identity.Commands
{
    public class LoginUserCommand : ICommand<ShopHubResponseModel>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
