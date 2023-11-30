using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class EntityBase : IRowLevelSecurity
    {
        public string ItemId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set;}
        public bool IsMarkedToDelete { get; set; }
        public string[] RolesAllowedToRead { get; set; }

        public string[] IdsAllowedToRead { get; set; }

        public string[] RolesAllowedToWrite { get; set; }

        public string[] IdsAllowedToWrite { get; set; }

        public string[] RolesAllowedToUpdate { get; set; }

        public string[] IdsAllowedToUpdate { get; set; }

        public string[] RolesAllowedToDelete { get; set; }

        public string[] IdsAllowedToDelete { get; set; }
    }
}
