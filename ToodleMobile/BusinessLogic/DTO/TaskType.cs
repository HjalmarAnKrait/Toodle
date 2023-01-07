using BusinessLogic.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.DTO
{
    /// <summary>
    /// Тип задачи.
    /// </summary>
    [Table("TaskTypes")]
    public class TaskType
    {
        public TaskType(string title, string description)
        {
            Title = title;
            Description = description;
            ConditionType = ConditionTypeEnum.MANUAL;
            ActiveDaysEnum = ActiveDaysEnum.EVERYDAY;
            IsActive = true;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? OrderPosition { get; set; }

        public ConditionTypeEnum ConditionType { get; set; } 

        public ActiveDaysEnum ActiveDaysEnum { get; set; }

        public int? ConditionTargetValue { get; set; }

        public bool IsActive { get; set; }

    }
}
