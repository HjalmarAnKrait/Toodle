using BusinessLogic.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.DTO
{
    [Table("TaskTypes")]
    public class TaskType
    {
        public TaskType(string title, string description)
        {
            Title = title;
            Description = description;
            ConditionType = ConditionTypeEnum.MANUAL;
            IsActive = true;
        }

        public TaskType(string title, string description, int? conditionValue,
            ConditionTypeEnum conditionType)
        {
            Title = title;
            Description = description;
            ConditionType = conditionType;
            ConditionValue = conditionValue;
            IsActive = true;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int? OrderPosition { get; set; }

        public ConditionTypeEnum ConditionType { get; set; } 

        public int? ConditionValue { get; set; }

        public bool IsActive { get; set; }

    }
}
