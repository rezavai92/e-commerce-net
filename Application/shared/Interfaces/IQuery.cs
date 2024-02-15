using Application.shared.Models;
using MediatR;

namespace Application.shared.Interfaces
{
    public interface IQuery<TResponse> : IRequest<ShopHubResponseModel<TResponse>>
    {
    }
}
