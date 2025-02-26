using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Product : Entity
    {
        public string? Name { get; set; } // Ürün adı (Örnek: "Domates", "Kola", vb.)
        public string? Description { get; set; } // Ürün açıklaması (isteğe bağlı)
        public string? Unit { get; set; } // Ürünün birimi (Örnek: "Kg", "Adet", "Litre", vb.)
        public decimal Price { get; set; } // Ürünün fiyatı
        public decimal? ReorderLevel { get; set; } // Yeniden sipariş verilmesi gereken stok seviyesi (isteğe bağlı)
    }
}
