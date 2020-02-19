using System.Linq;

namespace TasksToDo.ApplicationCore.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        IQueryable<TEntity> GetAll();

        TEntity GetById(int id);

        void Delete(TEntity entity);
    }
}
