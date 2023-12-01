using Application.shared.Interfaces;
using Application.shared.Models;
using Application.UAM.Commands;
using Application.UAM.Interfaces;
using AutoMapper;
using Domain.Entities;
using System.Net;

namespace Application.UAM.Services
{
    public class UamService : IUamService
    {

        private IShophubRepository _shophubRepository;
        private IMapper _mapper;

        public UamService(IShophubRepository shophubRepository, IMapper mapper)
        {
            _shophubRepository = shophubRepository;
            _mapper = mapper;
        }

        public async Task<ShopHubResponseModel> CreateUserAsync(CreateUserCommand command)
        {
            var response = new ShopHubResponseModel();
            try
            {
                var user = _mapper.Map<User>(command);
                await _shophubRepository.InsertItemAsync(user);
                response.SetSuccess(HttpStatusCode.Created, "User has been created successfully");

                return response;
            }
            catch (Exception ex)
            {
                response.SetError(HttpStatusCode.InternalServerError, ex.Message);

                return response;
            }
        }
    }
}
