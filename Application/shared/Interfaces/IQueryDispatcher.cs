using Application.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.shared.Interfaces
{
    public interface IQueryDispatcher
    {
        Task<TResponse> DispatchAsync<TQuery, TResponse>(TQuery query) where TQuery : IQuery<TResponse>;
        Task<ShopHubResponseModel> DispatchAsync<TQuery>(TQuery query) where TQuery : IQuery<ShopHubResponseModel>;
    }
}
