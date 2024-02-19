using Domain.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class EntityBase : IRowLevelSecurity
    {

        [Key]
        [Required]
        public string ItemId { get; set; }
        public string? CreatedByUserId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
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
