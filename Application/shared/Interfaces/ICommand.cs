using Application.shared.Models;
using MediatR;

namespace Application.shared.Interfaces
{
    public interface ICommand : IRequest<ServiceResponse>
    {
    }

    public interface ICommand<TResponse> : IRequest<ServiceResponse<TResponse>>
    {
    }
}
