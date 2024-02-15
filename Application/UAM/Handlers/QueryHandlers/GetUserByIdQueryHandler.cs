using Application.shared.Interfaces;
using Application.shared.Models;
using Application.UAM.Queries;
using Domain.Entities;

namespace Application.UAM.Handlers.QueryHandlers
{
    public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, User>
    {
        public Task<ShopHubResponseModel<User>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
