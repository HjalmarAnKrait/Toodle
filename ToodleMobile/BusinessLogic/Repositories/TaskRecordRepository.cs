using BusinessLogic.DTO;
using BusinessLogic.Enums;
using BusinessLogic.Repositories.Interfaces;
using MoreLinq;

namespace BusinessLogic.Repositories
{
    /// <summary>
    /// Репозиторий для взаимодействия с таблицей TaskRecord
    /// </summary>
    public class TaskRecordRepository : BaseRepository<TaskRecord>, ITaskRecordRepository
    {
        ///<inheritdoc/>
        public ITaskTypeRepository TaskTypeRepository => DataService.Instance.TaskTypeRepository;

        ///<inheritdoc/>
        public IEnumerable<TaskRecord> CreateTasksOnDay()
        {
            var activeTaskTypes = TaskTypeRepository.GetAll().Where(type => type.IsActive);

            var actualDayOfWeek = DateTime.Today.DayOfWeek;
            var isWeekend = actualDayOfWeek == DayOfWeek.Saturday && actualDayOfWeek == DayOfWeek.Sunday;
            var exceptedType = isWeekend ? ActiveDaysEnum.WORK_DAYS : ActiveDaysEnum.WEEKEND;
            //Нужно потестить, пока непонятно.
            //Исключить из всего списка те задачи, которые не нужно делать на определённый период
            var taskTypesToExcept = activeTaskTypes.Where(type => type.ActiveDaysEnum == exceptedType);
            var exceptedTaskTypes = activeTaskTypes.Except(taskTypesToExcept);

            var createdRecords = exceptedTaskTypes.Select(type => new TaskRecord(type)).ToList();
            AddRange(createdRecords);

            return createdRecords;
        }

        ///<inheritdoc/>
        public IEnumerable<TaskRecord> GetOrdered(OrderTypeEnum orderTypeEnum, bool descending = false)
        {
            var allActual = GetAll().Where(record => record.Date == DateOnly.FromDateTime(DateTime.Today));

            switch(orderTypeEnum)
            {
                case OrderTypeEnum.ID:
                    return allActual.OrderBy(record => record.Id).ToList();
                case OrderTypeEnum.COMPLETED:
                    return allActual.OrderBy(record => record.IsFinished).ToList();
                case OrderTypeEnum.TYPE:
                    return allActual.OrderBy(record => record.TaskType.ConditionType).ToList();
                case OrderTypeEnum.ORDER:
                    return allActual.OrderBy(record => record.TaskType.OrderPosition).ToList();

                default: throw new NotImplementedException("Другие сортировки не реализованы.");
            }
        }

        ///<inheritdoc/>
        public IEnumerable<TaskRecord> GetTaskRecordsByDate(DateOnly date)
        {
            return GetAll().Where(record => record.Equals(date)).ToList();
        }
    }
}
