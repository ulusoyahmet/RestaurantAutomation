using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class TableRepository : GenericCrudRepository<Table>
    {
        public TableRepository(AppDbContext context) : base(context)
        {
        }
    }
}
