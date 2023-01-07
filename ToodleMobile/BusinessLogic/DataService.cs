namespace BusinessLogic
{
    /// <summary>
    /// Сервис для работы с данными.
    /// </summary>
    public class DataService
    {
        /// <summary>
        /// <see cref="Instance"/>
        /// </summary>
        private static DataService _instance;

        /// <summary>
        /// Инстанц сервиса.
        /// </summary>
        public static DataService Instance => _instance ?? new DataService();

        public readonly DatabaseContext DatabaseContext;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        private DataService()
        {
            DatabaseContext = new DatabaseContext();
        }
    }
}
