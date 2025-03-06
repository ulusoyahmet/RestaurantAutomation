using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class OrderRepository : GenericCrudRepository<Order>
    {
        // add getbycompoundid and deletebycompoundid
        AppDbContext _context;
        public OrderRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Order GetByCompoundID(Guid tableID, Guid orderID)
        {
            return _context.Orders.Find(tableID, orderID);
        }

        public void DeleteByCompoundID(Guid tableID, Guid orderID)
        {
            var order = _context.Orders.Find(tableID, orderID);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
