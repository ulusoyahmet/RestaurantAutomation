using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class RoleRepository : GenericCrudRepository<Role>
    {
        public RoleRepository(AppDbContext context) : base(context)
        {
        }
    }
}
