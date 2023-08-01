using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Etickets_.Data.Base
{
    public class EnitiyBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {

        private readonly Eco_Context _Context;

        public EnitiyBaseRepository(Eco_Context context)
        {
            _Context = context;
        }


        public async void AddAsyc(T entity)
        {
            await _Context.Set<T>().AddAsync(entity);
            await _Context.SaveChangesAsync();
        }

        public async void DeleteAsyc(int id , T entity)
        {
            var Result = await _Context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _Context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await _Context.SaveChangesAsync();
        }

        public void DeleteAsyc(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetallAsyc() => await _Context.Set<T>().ToListAsync();
        public async Task<IEnumerable<T>> GetallAsyc(params Expression <Func<T , object>> [] includeProperties)
        {
            IQueryable<T> query = _Context.Set<T>();
            query = includeProperties.Aggregate(query, (Current, includeProperties) => Current.Include(includeProperties));
            return await query.ToListAsync();
        }

        public Task<IEnumerable<T>> GetallAsyc(Func<object, object> value)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetbyidAsyc(int id ) => await _Context.Set<T>().ToListAsync();
        public async Task<T> GetbyidAsyc(int id , params Expression<Func<T , object>>[] includeProperties)
        {
            IQueryable<T> query = _Context.Set<T>();
            query = includeProperties.Aggregate(query, (Current, includeProperties) => Current.Include(includeProperties));
            return await query.FirstOrDefaultAsync(n => n.Id == id);
         }

        public async Task UpdateAsyc (int id, T entity)
        {
            EntityEntry entityEntry = _Context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await _Context.SaveChangesAsync();

        }

        Task<T> IEntityBaseRepository<T>.GetbyidAsyc(int id, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        void IEntityBaseRepository<T>.UpdateAsyc(int id, T entity)
        {
            throw new NotImplementedException();
        }








        //public async Task<IActionResult> Edit(int id)
        //{
        //    var actorDetails = await _service.GetbyidAsyc(id);
        //    if (actorDetails == null) return View("NotFound");
        //    return View(actorDetails);
        //}

    }
}
