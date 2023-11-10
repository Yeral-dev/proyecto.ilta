

using hotel.domino.repository;
using hotel.infractructure.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace hotel.infractructure.Coree
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly Hotelcontext context;
        private DbSet<TEntity> entities;
        public BaseRepository(Hotelcontext context)
        {
            this.context = context;
            this.entities = this.context.Set<TEntity>();
        }
        public virtual bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            return this.entities.Any(filter);
        }

        public virtual List<TEntity> FindAll(Expression<Func<TEntity, bool>> filter)
        {
            return this.entities.Where(filter).ToList();
        }

        public virtual TEntity GetEntity(int id)
        {
            return this.entities.Find(id);
        }

        public virtual List<TEntity> GetTEntities()
        {
            return entities.ToList();
        }

        public virtual void Remove(TEntity entity)
        {
           this.entities.Remove(entity);    
        }

        public virtual void Save(TEntity entity)
        {
            this.entities.Add(entity);  
        }

        public virtual void Update(TEntity entity)
        {
            this.entities.Update(entity);   
        }
    }
}
