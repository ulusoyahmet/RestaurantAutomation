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
    public class TableService : ICrudRepository<Table>
    {
        private readonly TableRepository _tableRepository;

        public TableService(TableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public void Create(Table entity)
        {
            if (entity == null)
            {
                throw new Exception("Table entity boş olamaz.");
            }

            TableValidator tVal = new();
            ValidationResult result = tVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _tableRepository.Create(entity);

        }

        public void Delete(Guid id)
        {
            var obj = _tableRepository.GetByID(id);

            if (obj == null)
            {
                throw new Exception("Masa Bulunamadı.");
            }

            _tableRepository.Delete(id);
        }

        public IEnumerable<Table> GetAll()
        {
            return _tableRepository.GetAll();
        }

        public Table GetByID(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("ID bilgisi boş olamaz.");
            }

            return _tableRepository.GetByID(id);
        }

        public bool IfEntityExists(Expression<Func<Table, bool>> filter)
        {
            return _tableRepository.IfEntityExists(filter);
        }

        public void Update(Table entity)
        {
            if (entity == null)
            {
                throw new Exception("Table entity boş olamaz.");
            }

            TableValidator tVal = new();
            ValidationResult result = tVal.Validate(entity);

            if (!result.IsValid)
            {
                throw new Exception(string.Join("\n", result.Errors));
            }

            _tableRepository.Update(entity);
        }
    }
}
