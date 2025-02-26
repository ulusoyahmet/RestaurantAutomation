using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Reservation : Entity
    {
        public DateTime ReservationDate { get; set; }
        public Guid CustomerID { get; set; }
        public virtual Customer? Customer { get; set; }
        public Guid TableID { get; set; }
        public virtual Table? Table { get; set; }
    }
}
