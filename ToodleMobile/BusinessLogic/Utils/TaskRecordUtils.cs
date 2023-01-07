using BusinessLogic.DTO;

namespace BusinessLogic.Utils
{
    /// <summary>
    /// Вспомогательный класс для работы с записями задач.
    /// </summary>
    public static class TaskRecordUtils
    {
        /// <summary>
        /// Проверить задачу на выполненность.
        /// </summary>
        /// <param name="taskRecord"> Запись задачи. </param>
        /// <returns>true, если задача считается выполненной. </returns>
        public static bool CheckIsCompletedTaskRecord(TaskRecord taskRecord)
        {
            var taskType = taskRecord.TaskType;

            switch(taskType.ConditionType)
            {
                case Enums.ConditionTypeEnum.MANUAL:
                    return taskRecord.IsFinished;

                case Enums.ConditionTypeEnum.LESS:
                    return taskRecord.ConditionValue < taskType.ConditionTargetValue;

                case Enums.ConditionTypeEnum.MORE:
                    return taskRecord.ConditionValue > taskType.ConditionTargetValue;

                case Enums.ConditionTypeEnum.LESS_OR_EQUAL:
                    return taskRecord.ConditionValue <= taskType.ConditionTargetValue;

                case Enums.ConditionTypeEnum.MORE_OR_EQUAL:
                    return taskRecord.ConditionValue >= taskType.ConditionTargetValue;

                case Enums.ConditionTypeEnum.EQUAL:
                    return taskRecord.ConditionValue == taskType.ConditionTargetValue;

                default:
                    throw new ArgumentException("Такого енама ещё нет;)");
            }
        }

        /// <summary>
        /// Проверить задачу на выполненность и сохранить изменения.
        /// </summary>
        /// <param name="taskRecord"> Запись задачи. </param>
        /// <returns>true, если задача считается выполненной. </returns>
        public static bool CheckAndSaveProgress(TaskRecord taskRecord)
        {
            var completed = CheckIsCompletedTaskRecord(taskRecord);

            if (!completed)
                return false;

            taskRecord.IsFinished = true;
            DataService.Instance.TaskRecordRepository.AddOrUpdate(taskRecord);
            return true;
        }
    }
}
