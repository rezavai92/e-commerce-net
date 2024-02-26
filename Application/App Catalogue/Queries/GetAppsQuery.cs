using Application.shared.Interfaces;
using Application.shared.Models;

namespace Application.App_Catalogue.Queries
{
    public class GetAppsQuery : IQuery<ShopHubResponseModel>
    {
        public required List<string> UserRoles { get; set; }
    }
}
