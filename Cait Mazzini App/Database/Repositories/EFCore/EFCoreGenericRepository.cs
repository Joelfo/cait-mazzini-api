using Cait_Mazzini_App.Database.Contexts;
using Cait_Mazzini_App.Database.Repositories.Interfaces;

namespace Cait_Mazzini_App.Database.Repositories.EFCore
{
    public class EFCoreGenericRepository<TEntity, TPrimaryKey> : IGenericRepository<TEntity, TPrimaryKey> 
        where TEntity : class
    {
        protected readonly CaitMazziniDbContext _dbContext;
        public EFCoreGenericRepository(CaitMazziniDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IList<TEntity> All(int? skip = null, int? take = null)
        {
            var set = _dbContext.Set<TEntity>();
            if (skip.HasValue && take.HasValue)
            {
                return set.Skip(skip.Value).Take(take.Value).ToList();
            }
            else
            {
                return set.ToList();
            }
        }

        public virtual TEntity? Find(TPrimaryKey id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public virtual void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }

        public virtual void Delete(TPrimaryKey id)
        {
            var set = _dbContext.Set<TEntity>();
            var entity = set.Find(id);
            set.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
