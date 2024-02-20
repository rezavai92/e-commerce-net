using Application.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.shared.Interfaces
{
    public interface ICommandDispatcher
    {
        TResponse SendLocal<TCommand, TResponse>(TCommand command) where TCommand:ICommand<TResponse>;
        Task<TResponse> SendLocalAsync<TCommand, TResponse>(TCommand command) where TCommand : ICommand<TResponse>;
        Task<ShopHubResponseModel> SendLocalAsync<TCommand>(TCommand command) where TCommand : ICommand<ShopHubResponseModel>;
        TResponse SendToQueue<TResponse>(string queueName, object payload) where TResponse : new();

        TResponse SendToQueue<TResponse>(string queueName, object payload, int numberOfRetryAttempts,
            TimeSpan iterationDelay, bool keepInAFailQueue = false) where TResponse : new();

        //TResponse SendToQueue<TResponse>(string queueName, object payload, SecurityContext securityContext)
        //    where TResponse : new();

        //TResponse SendToQueue<TResponse>(string queueName, object payload, SecurityContext securityContext,
        //    int numberOfRetryAttempts, TimeSpan iterationDelay, bool keepInAFailQueue = false)
        //    where TResponse : new();
    }
}
