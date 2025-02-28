using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class UserRepository : GenericCrudRepository<User>
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
