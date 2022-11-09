using System.Linq.Expressions;
using System.Linq;
using System;
using System.Collections.Generic;
using Car.Entity;

namespace Car.Services
{
    public interface IRepository<T> where T : BaseEntity
    {
            IEnumerable<T> GetAll();
            T Get(long id);
            void Insert(T entity);
            void Update(T entity);
            void Delete(T entity);
    }
}
