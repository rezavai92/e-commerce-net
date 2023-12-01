using Application.shared.Models;
using MediatR;

namespace Application.shared.Interfaces
{
    public interface ICommand : IRequest<ShopHubResponseModel>
    {
    }

    public interface ICommand<TResponse> : IRequest<ShopHubResponseModel<TResponse>>
    {
    }
}
