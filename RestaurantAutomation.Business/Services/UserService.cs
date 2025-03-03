using System.Linq.Expressions;
using FluentValidation.Results;
using RestaurantAutomation.Business.Validators;
using RestaurantAutomation.DataAccess.Abstractions;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.Business.Services
{
    public class UserService : ICrudRepository<User>
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User entity)
        {
            if (entity == null)
            {
                throw new Exception("User entity boş olamaz.");
            }

            UserValidator uVal = new();
            ValidationResult result = uVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _userRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var obj = _userRepository.GetByID(id);

            if (obj == null)
            {
                throw new Exception("Kullanıcı Bulunamadı.");
            }

            _userRepository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _userRepository.GetByID(id);
        }

        public User GetByUserName(string userName)
        {
            return _userRepository.GetByUserName(userName);
        }

        public bool IfEntityExists(Expression<Func<User, bool>> filter)
        {
            return _userRepository.IfEntityExists(filter);
        }

        public void Update(User entity)
        {
            if (entity == null)
            {
                throw new Exception("User entity boş olamaz.");
            }

            UserValidator uVal = new();
            ValidationResult result = uVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _userRepository.Update(entity);
        }
    }
}
