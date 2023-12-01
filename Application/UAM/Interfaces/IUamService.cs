using Application.shared.Models;
using Application.UAM.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UAM.Interfaces
{
    public interface IUamService
    {
        public Task<ShopHubResponseModel> CreateUserAsync(CreateUserCommand command);
    }
}
