using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Campaign : Entity
    {
        public string? Name { get; set; } // Kampanyanın adı
        public string? Description { get; set; } // Kampanya açıklaması (isteğe bağlı)
        public DateTime StartDate { get; set; } // Kampanya başlangıç tarihi
        public DateTime EndDate { get; set; } // Kampanya bitiş tarihi
        public decimal DiscountPercentage { get; set; } // Kampanyanın uygulayacağı indirim oranı

        // Kampanyada yer alan menü öğeleri (Many-to-Many ilişki)
        public virtual ICollection<CampaignMenuItem>? CampaignMenuItems { get; set; }
    }
}
