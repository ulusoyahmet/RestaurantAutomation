using Microsoft.EntityFrameworkCore;
using RestaurantAutomation.DataAccess.Context;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.DataAccess.Repositories
{
    public class OrderDetailRepository : GenericCrudRepository<OrderDetail>
    {
        private readonly AppDbContext _dbContext;
        public OrderDetailRepository(AppDbContext context, AppDbContext dbContext) : base(context)
        {
            _dbContext = dbContext;
        }

        public void DeleteByCompositeKey(Guid orderID, Guid menuItemID)
        {
            var orderDetail = _dbContext.OrderDetails.FirstOrDefault(od => od.OrderID == orderID && od.MenuItemID == menuItemID);

            if (orderDetail == null)
            {
                throw new Exception("OrderDetail Bulunamadı.");
            }

            _dbContext.OrderDetails.Remove(orderDetail);
            _dbContext.SaveChanges();
        }

        public OrderDetail GetByCompositeKey(Guid orderID, Guid menuItemID)
        {
            var orderDetail = _dbContext.OrderDetails.FirstOrDefault(od => od.OrderID == orderID && od.MenuItemID == menuItemID);

            if (orderDetail == null)
            {
                throw new Exception("OrderDetail Bulunamadı.");
            }

            return orderDetail;
        }
    }
}
