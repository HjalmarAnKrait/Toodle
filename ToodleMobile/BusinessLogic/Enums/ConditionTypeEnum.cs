using System.ComponentModel;

namespace BusinessLogic.Enums
{
    /// <summary>
    /// Тип условия для проставления 
    /// </summary>
    public enum ConditionTypeEnum
    {
        [Description("Ручной режим простановки готовности.")]
        MANUAL = 0,

        [Description("Меньше порогового значения.")]
        LESS = 1,

        [Description("Больше порогового значения.")]
        MORE = 2,

        [Description("Равно пороговому значению.")]
        EQUAL = 3,

        [Description("Меньше или равно пороговому значению.")]
        LESS_OR_EQUAL = 4,

        [Description("Меньше или равно пороговому значению.")]
        MORE_OR_EQUAL = 5
    }
}
