using System.Linq.Expressions;
using RestaurantAutomation.DataAccess.Abstractions;
using RestaurantAutomation.Entities.Models;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Business.Validators;
using FluentValidation.Results;
namespace RestaurantAutomation.Business.Services
{
    public class CategoryService : ICrudRepository<Category>
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(Category entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            CategoryValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _categoryRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var obj = _categoryRepository.GetByID(id);

            if (obj == null)
            {
                throw new Exception("Ürün Bulunamadı.");
            }

            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _categoryRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Category, bool>> filter)
        {
            return _categoryRepository.IfEntityExists(filter);
        }

        public void Update(Category entity)
        {
            if (entity == null)
            {
                throw new Exception("Entity null olamaz.");
            }

            CategoryValidator cVal = new();
            ValidationResult result = cVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _categoryRepository.Update(entity);
        }
    }
}
