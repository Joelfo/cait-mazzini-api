using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreGenericRepository<TEntity, TPrimaryKey> : IGenericRepository<TEntity, TPrimaryKey> 
        where TEntity : class, new()
    {
        protected readonly CaitMazziniDbContext _dbContext;
        public EFCoreGenericRepository(CaitMazziniDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<IList<TEntity>> All(int? skip = null, int? take = null)
        {
            var set = _dbContext.Set<TEntity>();
            if (skip.HasValue && take.HasValue)
            {
                return await set.Skip(skip.Value).Take(take.Value).ToListAsync();
            }
            else
            {
                return await set.ToListAsync();
            }
        }

        public virtual async Task<TEntity?> Find(TPrimaryKey id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task Delete(TPrimaryKey id)
        {
            var set = _dbContext.Set<TEntity>();
            var entity = set.Find(id);
            set.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
