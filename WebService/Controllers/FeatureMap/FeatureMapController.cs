using Application.App_Catalogue.Commands;
using Application.App_Catalogue.Queries;
using Application.shared.Interfaces;
using Application.shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers.FeatureMap
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppCatalogueController : Controller
    {

        ICommandDispatcher _commandDispatcher;
        IQueryDispatcher _queryDispatcher;

        public AppCatalogueController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
        {

            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }

        [HttpPost("CreateFeatureRoleMaps")]
        public async Task<ShopHubResponseModel> CreateFeaturRoleMaps([FromBody] CreateFeatureRoleMapCommand command)
        {
            var result = await _commandDispatcher.SendLocalAsync<CreateFeatureRoleMapCommand>(command);

            return result;
        }




        [HttpGet("GetApps")]
        public async Task<ShopHubResponseModel> GetApps([FromQuery] GetAppsQuery query)
        {
            return await _queryDispatcher.DispatchAsync<GetAppsQuery>(query);

        }
    }
}
