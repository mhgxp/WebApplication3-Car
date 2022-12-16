using System.Linq.Expressions;
using System.Linq;
using System;
using System.Collections.Generic;
using Car.Entity;
using Microsoft.EntityFrameworkCore;

namespace Car.Services
{
    public interface IRepository<T> where T : BaseEntity
    {
            IEnumerable<T> GetAll();
            T GetDetail(long id);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
            bool Exists(int id);
             
    }
}
