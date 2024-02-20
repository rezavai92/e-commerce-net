

namespace Domain.Entities
{
    public class Role : EntityBase
    {
        public  required string  Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
