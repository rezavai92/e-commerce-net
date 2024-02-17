using Application.shared.Interfaces;
using Application.shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mediators
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private ISender _sender;

        public QueryDispatcher(ISender sender)
        {
            _sender = sender;
        }

        public async Task<TResponse> DispatchAsync<TQuery, TResponse>(TQuery query) where TQuery : IQuery<TResponse>
        {
           return await _sender.Send(query);
        }

        public async Task<ShopHubResponseModel> DispatchAsync<TQuery>(TQuery query) where TQuery : IQuery<ShopHubResponseModel>
        {
            return await _sender.Send(query);
        }
    }
}
