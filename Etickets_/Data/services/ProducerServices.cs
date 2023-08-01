using Etickets_.Data.Base;
using Etickets_.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Etickets_.Data.services
{
    public class ProducerServices : IEntityBaseRepository<producer>, IProducer
    {
        public void AddAsyc(producer entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsyc(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<producer>> GetallAsyc(params Expression<Func<producer, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<producer> GetbyidAsyc(int id, params Expression<Func<producer, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsyc(int id, producer entity)
        {
            throw new NotImplementedException();
        }
    }
}
