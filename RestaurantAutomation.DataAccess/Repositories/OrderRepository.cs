using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class OrderRepository : GenericCrudRepository<Order>
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}
