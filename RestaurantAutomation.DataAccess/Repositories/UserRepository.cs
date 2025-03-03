using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class UserRepository : GenericCrudRepository<User>
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public User GetByUserName(string userName)
        {
            return _context.Users.FirstOrDefault(x => x.Username == userName);
        }
    }
}
