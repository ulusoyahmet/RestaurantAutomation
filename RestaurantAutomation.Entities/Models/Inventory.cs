using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Inventory : Entity
    {
        public Guid? ProductID { get; set; }
        public virtual Product? Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
