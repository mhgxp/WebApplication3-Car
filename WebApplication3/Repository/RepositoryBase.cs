using Car.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using static CarApi.Models.CarContext;
using System.Linq;
using CarApi.Models;

namespace Car.Services
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly CarContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        public Repository(CarContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public T GetDetail(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
        public bool Exists(int id)
        {
            return entities.Any(e => e.Id == id);
        }
    }
}
