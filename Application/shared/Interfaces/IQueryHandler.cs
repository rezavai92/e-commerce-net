using Application.shared.Models;
using MediatR;

namespace Application.shared.Interfaces
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
    {
    }
    public interface IQueryHandler<TQuery> : IRequestHandler<TQuery, ShopHubResponseModel> where TQuery : IQuery
    {
    }
}
