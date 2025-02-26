using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Shift : Entity
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid EmployeeID { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
