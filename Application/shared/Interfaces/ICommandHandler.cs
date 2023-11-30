using Application.shared.Models;
using MediatR;

namespace Application.shared.Interfaces
{
    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand,ServiceResponse> where TCommand : ICommand  
    {
    }

    public interface ICommandHandler<TCommand,TResponse> : IRequestHandler<TCommand, ServiceResponse<TResponse>> where TCommand : ICommand<TResponse>
    {
    }
}
