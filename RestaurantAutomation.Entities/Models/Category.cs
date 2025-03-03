using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Category : Entity
    {
        public string? Name { get; set; } // Kategorinin adı (Örnek: "Yemek", "İçecek", vb.)
        public string? Description { get; set; } // Kategorinin açıklaması (isteğe bağlı)

        // MenuItem ile ilişki
        public virtual ICollection<MenuItem>? MenuItems { get; set; } // Bu kategoriye ait menü öğeleri

        public override string ToString()
        {
            return Name;
        }

    }
}
