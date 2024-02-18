using Application.shared.Interfaces;
using Application.shared.Models;
using Application.shared.Queries;
using Application.shared.services;

namespace Application.shared.Handlers.QueryHandlers
{
    public class GenericGetByIdQueryHandler : IQueryHandler<GenericGetByIdQuery, ShopHubResponseModel>
    {
        private IGenericQueryService _genericQueryService;

        public GenericGetByIdQueryHandler(IGenericQueryService genericQueryService)
        {
            _genericQueryService = genericQueryService;
        }

        public async Task<ShopHubResponseModel> Handle(GenericGetByIdQuery query, CancellationToken cancellationToken)
        {

            return await _genericQueryService.GetItemByIdAsync(query.entity, query.ItemId);
        }
    }
}
