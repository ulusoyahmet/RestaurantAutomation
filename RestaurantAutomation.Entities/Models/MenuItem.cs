using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class MenuItem : Entity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        // category of the menu item
        public Guid CategoryID { get; set; }
        public virtual Category? Category { get; set; }
    }
}
