using Application.shared.Interfaces;
using Application.shared.Models;
using Application.UAM.Queries;
using Domain.Entities;

namespace Application.UAM.Handlers.QueryHandlers
{
    public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery,ShopHubResponseModel>
    {
        public async Task<ShopHubResponseModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
           Task.Delay(500).Wait();

            return new ShopHubResponseModel();  
        }
    }
}
