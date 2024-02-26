using Application.App_Catalogue.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.App_Catalogue.Handlers.QueryHandlers
{
    public class GetAllFeatureRoleMapQueryHandler : IQueryHandler<GetAppsQuery, ShopHubResponseModel>
    {
        private IFeatureRoleMapRepository _repo;

        public GetAllFeatureRoleMapQueryHandler(IFeatureRoleMapRepository repo)
        {
            _repo = repo;
        }

        public async Task<ShopHubResponseModel> Handle(GetAppsQuery query, CancellationToken cancellationToken)
        {
            var response = new ShopHubResponseModel();

            try
            {
                var items = await _repo.GetFeatureRoleMapsAsync((item => query.UserRoles.Contains(item.RoleName)));
                
                response.SetSuccess(items); 
            }
            catch (Exception ex)
            {
                response.SetError(System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }
    }
}
