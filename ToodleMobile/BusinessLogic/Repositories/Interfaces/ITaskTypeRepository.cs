using BusinessLogic.DTO;
using BusinessLogic.Enums;

namespace BusinessLogic.Repositories.Interfaces
{
    /// <summary>
    /// Репозиторий для работы с таблицей TaskType.
    /// </summary>
    public interface ITaskTypeRepository : IRepositoryBase<TaskType>
    {
        /// <summary>
        /// Удалить все неактивные записи.
        /// </summary>
        public void RemoveUnactiveTaskTypes();
    }
}
