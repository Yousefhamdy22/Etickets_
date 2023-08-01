using Etickets_.Data.Base;
using Etickets_.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Etickets_.Data.services
{
    public class CinemaServices : IEntityBaseRepository<Cinema>, ICenima
    {
        public void AddAsyc(Cinema entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsyc(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cinema>> GetallAsyc(params Expression<Func<Cinema, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Cinema> GetbyidAsyc(int id, params Expression<Func<Cinema, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsyc(int id, Cinema entity)
        {
            throw new NotImplementedException();
        }
    }
}
