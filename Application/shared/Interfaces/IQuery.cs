using Application.shared.Models;
using MediatR;

namespace Application.shared.Interfaces
{
  //  public interface IQuery<TResponse> : IRequest<ShopHubResponseModel<TResponse>>;
    public interface IQuery<TResponse>: IRequest<TResponse>;
    public interface IQuery : IRequest<ShopHubResponseModel>
    {
    }


}
