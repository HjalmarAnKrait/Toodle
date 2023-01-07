using System.ComponentModel;

namespace BusinessLogic.Enums
{
    /// <summary>
    /// Дни, когда будет создаваться задача.
    /// </summary>
    public enum ActiveDaysEnum
    {
        [Description("Все дни.")]
        EVERYDAY = 0,

        [Description("Выходные(СБ, ВТ).")]
        WEEKEND = 1,

        [Description("Будни.")]
        WORK_DAYS = 2,
    }
}
