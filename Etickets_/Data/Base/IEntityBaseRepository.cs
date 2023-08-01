using Etickets_.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Etickets_.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class  , IEntityBase ,new()
    {
        Task<IEnumerable<T>> GetallAsyc(params Expression<Func<T, object>>[] includeProperties);

        Task<T> GetbyidAsyc(int id, params Expression<Func<T, object>>[] includeProperties);

        void AddAsyc(T entity);

        void UpdateAsyc(int id, T entity);

        void DeleteAsyc(int id);
    }
}
