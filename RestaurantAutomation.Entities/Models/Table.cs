using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Table : Entity
    {
        public int TableNumber { get; set; } // Masa numarası
        public string? Status { get; set; } // Masa durumu (boş, dolu, rezerve)
        public Guid ReservationID { get; set; } // Rezervasyon ilişkisi
    }
}
