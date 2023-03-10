namespace BusinessLogic.Repositories.Interfaces
{
    /// <summary>
    /// Основа для репозитория.
    /// </summary>
    /// <typeparam name="T"> Класс сущности. </typeparam>
    public interface IRepositoryBase<T>
    {
        /// <summary>
        /// Получить по ID.
        /// </summary>
        /// <param name="id"> ID сущности. </param>
        /// <returns> Результат получения. </returns>
        public T GetById(int id);

        /// <summary>
        /// Добавить или обновить сущность.
        /// </summary>
        /// <param name="entity"> Сущность. </param>
        public void AddOrUpdate(T entity);

        /// <summary>
        /// Добавить диапазон значений.
        /// </summary>
        /// <param name="values"> значения. </param>
        public void AddRange(ICollection<T> values);

        /// <summary>
        /// Удалить сущность.
        /// </summary>
        /// <param name="entity"> Сущность. </param>
        public void Remove(T entity);

        /// <summary>
        /// Получить все сущности.
        /// </summary>
        /// <returns> Список сущностей. </returns>
        public IEnumerable<T> GetAll();
    }
}
