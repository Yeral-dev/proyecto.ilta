using System;
using System.Collections.Generic;
using System.Text;

namespace hotel.domino.repository
{
 
        public interface IBaseRepository<TEntity> where TEntity : class
        {
            void Save(TEntity entity);
            void Update(TEntity entity);
            void Remove(TEntity entity);
            List<TEntity> GetTEntity();
            TEntity GetRECEPCION(int id);
        }
    }

