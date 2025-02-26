using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class User : Entity
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public Guid RoleID { get; set; }
        public virtual Role? Role { get; set; }
    }
}
