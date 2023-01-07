using System.ComponentModel;

namespace BusinessLogic.Enums
{
    /// <summary>
    /// Порядок вывода.
    /// </summary>
    public enum OrderTypeEnum
    {
        [Description("По ID.")]
        ID = 0,

        [Description("По порядковому номеру.")]
        ORDER = 1,

        [Description("По завершённости.")]
        COMPLETED = 2,

        [Description("Больше порогового значения.")]
        TYPE = 3,
    }
}
