namespace Domain.Entities
{
    public class FeatureEndpointMap : EntityBase
    {

        public string Action { get; set; }
        public string Controller { get; set; }
        public ICollection<FeatureRoleMap> FeatureRoleMaps { get; set; } = new HashSet<FeatureRoleMap>();
    }
}
