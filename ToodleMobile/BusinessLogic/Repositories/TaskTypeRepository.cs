using BusinessLogic.DTO;
using BusinessLogic.Repositories.Interfaces;
using MoreLinq;

namespace BusinessLogic.Repositories
{
    /// <summary>
    /// Репозиторий для взаимодействия с таблицей TaskType.
    /// </summary>
    public class TaskTypeRepository : BaseRepository<TaskType>, ITaskTypeRepository
    {
        ///<inheritdoc/>
        public void RemoveUnactiveTaskTypes()
        {
            var unactiveTaskTypes = GetAll().Where(x => x.IsActive == false);
            unactiveTaskTypes.ForEach(type => Remove(type));
        }
    }
}
