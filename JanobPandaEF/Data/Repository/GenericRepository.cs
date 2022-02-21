using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace JanobPandaEF
{
#pragma warning disable
    internal abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private NajotTalimDbContext _najotTalimDbContext;
        private DbSet<T> dbSet { get; set; }
        public GenericRepository()
        {
            _najotTalimDbContext = new NajotTalimDbContext();
            this.dbSet = _najotTalimDbContext.Set<T>();
        }

        /// <summary>
        /// asdasdasd
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        /// <summary>
        /// asdasdw4g
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            Expression<Func<T, bool>> pred = p => true;

            return dbSet.Where(predicate ?? pred);
        }

        /// <summary>
        /// f3rg4e5h4 4g545
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> CreateAsync(T entity)
        {
            EntityEntry entry = await dbSet.AddAsync(entity);

            await _najotTalimDbContext.SaveChangesAsync();

            return (T)entry.Entity;
        }

        /// <summary>
        /// daf3w4g43g5
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await dbSet.FirstOrDefaultAsync(predicate);

            if (entity is null)
                return false;

            dbSet.Remove(entity);

            await _najotTalimDbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// g345g4tbrtnyrt
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<T> UpdateAsync(T entity)
        {
            //_najotTalimDbContext.Entry(entity).State = EntityState.Modified;

            var entry = dbSet.Update(entity);

            await _najotTalimDbContext.SaveChangesAsync();

            return entry.Entity;
        }
    }
}