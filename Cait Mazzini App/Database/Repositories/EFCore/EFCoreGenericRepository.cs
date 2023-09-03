using Cait_Mazzini_App.Database.Contexts;
using Cait_Mazzini_App.Database.Repositories.Interfaces;

namespace Cait_Mazzini_App.Database.Repositories.EFCore
{
    public class EFCoreGenericRepository<TEntity, TPrimaryKey> : IGenericRepository<TEntity, TPrimaryKey> 
        where TEntity : class
    {
        private readonly CaitMazziniDbContext _dbContext;
        public EFCoreGenericRepository(CaitMazziniDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TEntity> All(int skip, int take)
        {
            return _dbContext.Set<TEntity>().Skip(skip).Take(take).ToList();
        }

        public TEntity? Find(TPrimaryKey id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(TPrimaryKey id)
        {
            var set = _dbContext.Set<TEntity>();
            var entity = set.Find(id);
            set.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
