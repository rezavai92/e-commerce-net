using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EntityBase : IRowLevelSecurity
    {

        [Key]
        public string ItemId { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow; 
        public DateTime UpdatedOn { get; set;} = DateTime.UtcNow;
        public bool IsMarkedToDelete { get; set; } = false;
        public string[] RolesAllowedToRead { get; set; } = new string[0];   

        public string[] IdsAllowedToRead { get; set; } = new string[0];

        public string[] RolesAllowedToWrite { get; set; } = new string[0];

        public string[] IdsAllowedToWrite { get; set; } = new string[0];

        public string[] RolesAllowedToUpdate { get; set; } = new string[0];

        public string[] IdsAllowedToUpdate { get; set; } = new string[0];

        public string[] RolesAllowedToDelete { get; set; } = new string[0];

        public string[] IdsAllowedToDelete { get; set; } = new string[0];
    }
}
