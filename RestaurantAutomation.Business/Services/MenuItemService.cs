using FluentValidation.Results;
using RestaurantAutomation.Business.Validators;
using RestaurantAutomation.DataAccess.Abstractions;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;
using System.Linq.Expressions;

namespace RestaurantAutomation.Business.Services
{
    public class MenuItemService : ICrudRepository<MenuItem>
    {
        private readonly MenuItemRepository _menuItemRepository;

        public MenuItemService(MenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public void Create(MenuItem entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            MenuItemValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _menuItemRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var obj = _menuItemRepository.GetByID(id);

            if (obj == null)
            {
                throw new Exception("Ürün Bulunamadı.");
            }

            _menuItemRepository.Delete(id);
        }

        public IEnumerable<MenuItem> GetAll()
        {
            return _menuItemRepository.GetAll();
        }

        public MenuItem GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _menuItemRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<MenuItem, bool>> filter)
        {
            return _menuItemRepository.IfEntityExists(filter);
        }

        public void Update(MenuItem entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            MenuItemValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _menuItemRepository.Update(entity);
        }
    }
}
