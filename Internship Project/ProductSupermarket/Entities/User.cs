using ProductSupermarket.Enums;

namespace ProductSupermarket.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public AccessRightsEnum AccessRights { get; set; }
        public bool IsActive { get; set; }
    }
}
