using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LanguageMentor.Core.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Find(int id);

        void Update(TEntity entity);

        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
    }
}