namespace Domain.Entities
{
    public class FeatureRoleMap : EntityBase
    {
        public required string FeatureId { get; set; }
        public  required string FeatureName { get; set; }
        public required string AppName { get; set; }
        public required string RoleName { get; set; }
        public ICollection<FeatureEndpointMap>? FeatureEndpointMaps { get; set; } = new HashSet<FeatureEndpointMap>();  
    }
}
