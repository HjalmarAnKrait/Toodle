namespace ToodleMobile.DAL
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

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        private DataService()
        {
        }
    }
}
