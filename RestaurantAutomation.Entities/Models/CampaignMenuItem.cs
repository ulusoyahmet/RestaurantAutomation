using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class CampaignMenuItem : Entity
    {
        public Guid CampaignID { get; set; } // Kampanya ID'si
        public virtual Campaign? Campaign { get; set; } // Kampanya ile ilişki

        public Guid MenuItemID { get; set; } // Menü öğesi ID'si
        public virtual MenuItem? MenuItem { get; set; } // Menü öğesi ile ilişki
    }
}
