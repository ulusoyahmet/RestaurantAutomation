using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Order : Entity
    {
        public DateTime OrderDate { get; set; }
        public Guid CustomerID { get; set; }
        public Guid TableID { get; set; }
        public virtual Table? Table { get; set; }
        public Guid PaymentID { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}
