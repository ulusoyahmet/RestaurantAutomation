using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class PaymentRepository : GenericCrudRepository<Payment>
    {
        public PaymentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
