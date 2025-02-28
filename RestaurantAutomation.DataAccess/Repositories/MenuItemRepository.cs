using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class MenuItemRepository : GenericCrudRepository<MenuItem>
    {
        public MenuItemRepository(AppDbContext context) : base(context)
        {
        }
    }
}
