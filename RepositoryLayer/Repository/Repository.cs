using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MinhNhatShopDbContext db;
        private DbSet<T> entities;
        public Repository(MinhNhatShopDbContext db)
        {
            this.db = db;
            entities = db.Set<T>();
        }

        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            db.SaveChanges();
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(X => X.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentException();
            }
            entities.Add(entity);
            db.SaveChanges();
        }

        public void Remove(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentException();
            }
            entities.Remove(entity);
            db.SaveChanges();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentException();
            }
            entities.Update(entity);
            db.SaveChanges();
        }
    }
}
