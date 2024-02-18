using Application.shared.Interfaces;
using Application.shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductApp.Queries
{
    public class GetProductsQuery : IQuery<ShopHubResponseModel>
    {
        public IEnumerable<string> CategoryIds { get; set; }
        public IEnumerable<string> BrandIds { get; set; }
        public double MinimumPrice { get; set; }
        public double MaximumPrice { get; set; }
        public string SearchKey { get; set; }
    }
}
