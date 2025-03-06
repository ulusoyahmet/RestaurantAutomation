using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Order : Entity
    {
        public DateTime OrderDate { get; set; }        
        public Guid TableID { get; set; }
        public virtual Table? Table { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}
