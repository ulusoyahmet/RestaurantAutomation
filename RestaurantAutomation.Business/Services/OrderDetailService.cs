using FluentValidation.Results;
using RestaurantAutomation.DataAccess.Abstractions;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;
using System.Linq.Expressions;

namespace RestaurantAutomation.Business.Services
{
    public class OrderDetailService : ICrudRepository<OrderDetail>
    {
        private readonly OrderDetailRepository _orderDetailRepository;
        public OrderDetailService(OrderDetailRepository cRepo)
        {
            _orderDetailRepository = cRepo;
        }
        public void Create(OrderDetail entity)
        {
            OrderDetailValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _orderDetailRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var obj = _orderDetailRepository.GetByID(id);

            if (obj == null)
            {
                throw new Exception("Sipariş Detay Bulunamadı.");
            }


            _orderDetailRepository.Delete(id);
        }

        public void DeleteByOrderProductID(Guid orderID, Guid menuItemID)
        {
            if (orderID == Guid.Empty || menuItemID == Guid.Empty)
            {
                throw new Exception("MenuItemID veya OrderID bilgisi boş olamaz.");
            }

            _orderDetailRepository.DeleteByCompositeKey(orderID, menuItemID);
        }

        public OrderDetail GetByOrderProductID(Guid orderID, Guid menuItemID)
        {
            if (orderID == Guid.Empty || menuItemID == Guid.Empty)
            {
                throw new Exception("MenuItemID veya OrderID bilgisi boş olamaz.");
            }

            return _orderDetailRepository.GetByCompositeKey(orderID, menuItemID);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public OrderDetail GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _orderDetailRepository.GetByID(id);

        }

        public bool IfEntityExists(Expression<Func<OrderDetail, bool>> filter)
        {
            return _orderDetailRepository.IfEntityExists(filter);
        }

        public void Update(OrderDetail entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _orderDetailRepository.Update(entity);
        }
    }
}
