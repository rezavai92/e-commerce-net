using Application.shared.Interfaces;
using Application.shared.Models;
using MediatR;

namespace Infrastructure.Mediators
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private ISender _sender;

        public CommandDispatcher(ISender sender)
        {
            _sender = sender;
        }

        public TResponse SendLocal<TCommand, TResponse>(TCommand command) where TCommand : ICommand<TResponse>
        {
            return SendLocalAsync<TCommand, TResponse>(command).Result;
        }

        public async Task<TResponse> SendLocalAsync<TCommand, TResponse>(TCommand command) where TCommand : ICommand<TResponse>
        {
            return await _sender.Send(command);
        }

        public async Task<ShopHubResponseModel> SendLocalAsync<TCommand>(TCommand command) where TCommand : ICommand<ShopHubResponseModel>
        {
            return await _sender.Send(command);
        }

        public TResponse SendToQueue<TResponse>(string queueName, object payload) where TResponse : new()
        {
            throw new NotImplementedException();
        }

        public TResponse SendToQueue<TResponse>(string queueName, object payload, int numberOfRetryAttempts, TimeSpan iterationDelay, bool keepInAFailQueue = false) where TResponse : new()
        {
            throw new NotImplementedException();
        }
    }
}
