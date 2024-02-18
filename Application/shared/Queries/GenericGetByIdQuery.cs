using Application.shared.Interfaces;
using Application.shared.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.shared.Queries
{
    public class GenericGetByIdQuery : IQuery<ShopHubResponseModel>
    {
        public string ItemId { get; set; }
        public EntityBase entity { get; set; }
      
    }
}
