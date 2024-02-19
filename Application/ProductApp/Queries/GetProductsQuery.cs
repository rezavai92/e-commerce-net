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
        public List<string> CategoryIds { get; set; } = new List<string>();  
        public List<string> BrandIds { get; set; } = new List<string>(); 
        public double? MinimumPrice { get; set; }
        public double? MaximumPrice { get; set; }
        public string SearchKey { get; set; } = string.Empty;
    }
}
