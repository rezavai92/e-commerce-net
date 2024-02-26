using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.App_Catalogue.Commands
{
    public class CreateFeatureRoleMapCommand : ICommand<ShopHubResponseModel>
    {
        public List<SingleRoleMap>? FeatureRoleMaps { get; set; }
       
    }

    public class SingleRoleMap
    {
        public required string FeatureId { get; set; }
        public required string FeatureName { get; set; }
        public required string AppName { get; set; }
        public required string RoleName { get; set; }
    //    public List<SingleEndpointMap>? FeatureEndpointMaps { get; set; }
    }

    public class SingleEndpointMap
    {
        public string Action { get; set; }
        public string Controller { get; set; }
    }
}
