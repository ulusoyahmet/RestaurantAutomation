using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RestaurantAutomation.DataAccess.Context;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class TableRepository : GenericCrudRepository<Table>
    {
        public TableRepository(AppDbContext context) : base(context)
        {
        }
    }
}
