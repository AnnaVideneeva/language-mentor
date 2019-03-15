using System;
using System.Linq;

namespace LanguageMentor.Core.Data
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> GetAsNoTracking();

        IQueryable<TEntity> Get();

        void Update(TEntity entity);
    }
}