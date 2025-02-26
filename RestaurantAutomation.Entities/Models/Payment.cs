using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Payment : Entity
    {
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid OrderID { get; set; }
        public virtual Order? Order { get; set; }
    }
}
