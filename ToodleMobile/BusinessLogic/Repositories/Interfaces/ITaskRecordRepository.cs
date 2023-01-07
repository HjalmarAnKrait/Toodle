using BusinessLogic.DTO;
using BusinessLogic.Enums;

namespace BusinessLogic.Repositories.Interfaces
{
    /// <summary>
    /// Репозиторий для работы с таблицей задач.
    /// </summary>
    public interface ITaskRecordRepository : IRepositoryBase<TaskRecord>
    {
        ITaskTypeRepository TaskTypeRepository { get; }

        /// <summary>
        /// Получить активные, упорядоченные записи.
        /// </summary>
        /// <param name="orderTypeEnum"> Тип сортировки. </param>
        /// <param name="descending"> Делать сортировку по убыванию. </param>
        /// <returns> Упорядоченные, активные записи. </returns>
        public IEnumerable<TaskRecord> GetOrdered(OrderTypeEnum orderTypeEnum, bool descending = false);

        /// <summary>
        /// Создать задачи на день.
        /// </summary>
        /// <returns> Созданные задачи на текущий день. </returns>
        public IEnumerable<TaskRecord> CreateTasksOnDay();

        /// <summary>
        /// Получить список задач на определённую дату.
        /// </summary>
        /// <returns> Список задач на заданную дату. </returns>
        public IEnumerable<TaskRecord> GetTaskRecordsByDate(DateOnly date);
    }
}
