using Application.shared.Models;
using MediatR;

namespace Application.shared.Interfaces
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, ShopHubResponseModel> where TCommand : ICommand
    {
    }

    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
    {
    }
}
