using FluentValidation.Results;
using RestaurantAutomation.DataAccess.Abstractions;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;
using System.Linq.Expressions;

namespace RestaurantAutomation.Business.Services
{
    public class OrderService : ICrudRepository<Order>
    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository cRepo)
        {
            _orderRepository = cRepo;
        }
        public void Create(Order entity)
        {
            OrderValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _orderRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var obj = _orderRepository.GetByID(id);

            if (obj == null)
            {
                throw new Exception("Sipariş Bulunamadı.");
            }

            _orderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _orderRepository.GetByID(id);

        }

        public bool IfEntityExists(Expression<Func<Order, bool>> filter)
        {
            return _orderRepository.IfEntityExists(filter);
        }

        public void Update(Order entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            _orderRepository.Update(entity);
        }
    }
}
