using BusinessLogic.Repositories.Interfaces;
using MoreLinq;

namespace BusinessLogic.Repositories
{
    /// <summary>
    /// Базовая реализация IRepositoryBase
    /// </summary>
    /// <typeparam name="T"> Шаблонный тип, для которого будет создаваться репозиторий. </typeparam>
    public abstract class BaseRepository<T> : IRepositoryBase<T> where T : class
    {
        /// <summary>
        /// Контекст базы данных.
        /// </summary>
        public readonly DatabaseContext DatabaseContext;

        public BaseRepository()
        {
            DatabaseContext = DataService.DatabaseContext;
        }

        ///<inheritdoc/>
        public void AddOrUpdate(T entity)
        {
            DatabaseContext.Update<T>(entity);
            DatabaseContext.SaveChanges();
        }

        ///<inheritdoc/>
        public void Remove(T entity)
        {
            DatabaseContext.Remove<T>(entity);
            DatabaseContext.SaveChanges();
        }

        ///<inheritdoc/>
        public IEnumerable<T> GetAll()
        {
            return DatabaseContext.Set<T>();
        }

        ///<inheritdoc/>
        public T GetById(int id)
        {
            return DatabaseContext.Find<T>(id)!;
        }

        ///<inheritdoc/>
        public void AddRange(ICollection<T> values)
        {
            values.ForEach(value => DatabaseContext.Add<T>(value));
            DatabaseContext.SaveChanges();
        }
    }
}
