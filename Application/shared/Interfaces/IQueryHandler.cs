using Application.shared.Models;
using MediatR;

namespace Application.shared.Interfaces
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, ShopHubResponseModel<TResponse>> where TQuery : IQuery<TResponse>
    {
    }
}
