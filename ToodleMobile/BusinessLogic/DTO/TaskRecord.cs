using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.DTO
{
    /// <summary>
    /// Запись задачи..
    /// </summary>
    [Table("TaskRecords")]
    public class TaskRecord
    {
        public int? Id { get; set; }

        public DateOnly Date { get; set; }

        public TaskType TaskType { get; set; }

        public bool IsFinished { get; set; }

        public int? ConditionValue { get; set; }
        
        private TaskRecord() { }//Нужен для корректного связывания свойства навигации.

        public TaskRecord(TaskType taskType)
        {
            Date = DateOnly.FromDateTime(DateTime.Now);
            TaskType = taskType;
            IsFinished = false;
        }
    }
}
