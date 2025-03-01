using System.Linq.Expressions;
using FluentValidation.Results;
using RestaurantAutomation.Business.Validators;
using RestaurantAutomation.DataAccess.Abstractions;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.Business.Services
{
    public class RoleService : ICrudRepository<Role>
    {
        private readonly RoleRepository _roleRepository;

        public RoleService(RoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public void Create(Role entity)
        {
            RoleValidator rVal = new();
            ValidationResult result = rVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _roleRepository.Create(entity);

        }

        public void Delete(Guid id)
        {
            var obj = _roleRepository.GetByID(id);

            if (obj == null)
            {
                throw new Exception("Rol Bulunamadı.");
            }

            _roleRepository.Delete(id);
        }

        public IEnumerable<Role> GetAll()
        {
            return _roleRepository.GetAll();
        }

        public Role GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _roleRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Role, bool>> filter)
        {
            return _roleRepository.IfEntityExists(filter);
        }

        public void Update(Role entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek rol bilgisi boş olamaz.");
            }

            RoleValidator rVal = new();
            ValidationResult result = rVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _roleRepository.Update(entity);
        }
    }
}
