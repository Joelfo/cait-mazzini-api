using Cait_Mazzini_App.Models;

namespace Cait_Mazzini_App.Database.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity, TPrimaryKey> where TEntity : class
    {
        IList<TEntity> All(int? skip, int? take);

        TEntity? Find(TPrimaryKey id);

        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TPrimaryKey id);
    }
}
