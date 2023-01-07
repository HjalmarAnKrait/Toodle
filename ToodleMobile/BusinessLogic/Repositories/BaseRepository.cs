using BusinessLogic.Repositories.Interfaces;

namespace BusinessLogic.Repositories
{
    public abstract class BaseRepository<T> : IRepositoryBase<T>
    {
        ///<inheritdoc/>
        public void AddOrUpdate(T entity)
        {
            throw new NotImplementedException();
        }

        ///<inheritdoc/>
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        ///<inheritdoc/>
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        ///<inheritdoc/>
        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
