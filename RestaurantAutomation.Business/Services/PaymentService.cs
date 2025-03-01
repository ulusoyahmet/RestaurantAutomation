using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using RestaurantAutomation.Business.Validators;
using RestaurantAutomation.DataAccess.Abstractions;
using RestaurantAutomation.DataAccess.Repositories;
using RestaurantAutomation.Entities.Models;

namespace RestaurantAutomation.Business.Services
{
    public class PaymentService : ICrudRepository<Payment>
    {
        private readonly PaymentRepository _paymentRepository;

        public PaymentService(PaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public void Create(Payment entity)
        {
            PaymentValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _paymentRepository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var obj = _paymentRepository.GetByID(id);

            if (obj == null)
            {
                throw new Exception("Ödeme Bulunamadı.");
            }

            _paymentRepository.Delete(id);
        }

        public IEnumerable<Payment> GetAll()
        {
            return _paymentRepository.GetAll();
        }

        public Payment GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _paymentRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Payment, bool>> filter)
        {
            return _paymentRepository.IfEntityExists(filter);
        }

        public void Update(Payment entity)
        {
            if (entity == null)
            {
                throw new Exception("Ödeme bilgisi boş olamaz.");
            }

            PaymentValidator pVal = new();
            ValidationResult result = pVal.Validate(entity);
            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }
            _paymentRepository.Update(entity);
        }
    }
}
