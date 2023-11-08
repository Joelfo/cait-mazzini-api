using CaitMazziniApp.Models;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity, TPrimaryKey> where TEntity : class
    {
        Task<IList<TEntity>> All(int? skip, int? take);

        Task<TEntity?> Find(TPrimaryKey id);

        Task Create(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TPrimaryKey id);
    }
}
