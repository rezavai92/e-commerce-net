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
        public Task<ShopHubResponseModel> CreateUsersAsync(CreateUserCommand command);
        public Task<ShopHubResponseModel> UpdateUserAsync(CreateUserCommand command);
        public Task<ShopHubResponseModel> UpdateUsersAsync(CreateUserCommand command);
        public Task<ShopHubResponseModel> GetUserAsync(CreateUserCommand command);
        public Task<ShopHubResponseModel> GetUsersAsync(CreateUserCommand command);
    }
}
