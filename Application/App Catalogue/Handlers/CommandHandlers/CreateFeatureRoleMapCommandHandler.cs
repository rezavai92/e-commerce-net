using Application.App_Catalogue.Commands;
using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.App_Catalogue.Handlers.CommandHandlers
{
    public class CreateFeatureRoleMapCommandHandler : ICommandHandler<CreateFeatureRoleMapCommand, ShopHubResponseModel>
    {
        private IFeatureRoleMapRepository _repository;

        public CreateFeatureRoleMapCommandHandler(IFeatureRoleMapRepository repository)
        {
            _repository = repository;
        }

        public async Task<ShopHubResponseModel> Handle(CreateFeatureRoleMapCommand command, CancellationToken cancellationToken)
        {
            var response = new ShopHubResponseModel();

            try
            {
                if (command.FeatureRoleMaps == null || !command.FeatureRoleMaps.Any())
                {
                    return response.SetError(System.Net.HttpStatusCode.BadRequest);
                }

               

                var featureRoleMapCommands = command.FeatureRoleMaps.Select(cmd => new FeatureRoleMap
                {
                    AppName = cmd.AppName,
                    FeatureId = cmd.FeatureId,
                    FeatureName = cmd.FeatureName,
                    ItemId = Guid.NewGuid().ToString(),
                    RoleName = cmd.RoleName,
                    FeatureEndpointMaps = new List<FeatureEndpointMap> { }

                });


                var result = await _repository.CreateManyFeatureRoleMapAsync(featureRoleMapCommands.ToList());

                if (result)
                {
                    return response.SetSuccess(System.Net.HttpStatusCode.Created, "created successfully");
                }
                response.SetError(System.Net.HttpStatusCode.BadRequest, "failed");
            }
            catch (Exception ex)
            {

                response.SetError(System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }
    }
}
