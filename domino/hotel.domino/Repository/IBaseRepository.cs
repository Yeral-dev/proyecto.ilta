using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Repository
{
    public interface IBaseRepository <TEntity> where TEntity : class
    {
      void save (TEntity entity);
      
      void Update (TEntity entity);
  
      void Remove (TEntity entity);

      List<TEntity> GetEntities ();

        TEntity GetEntity (int id);


    }
}
