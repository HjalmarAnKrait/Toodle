using BusinessLogic.Repositories;
using BusinessLogic.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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
        public static DataService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataService();
                }
                    

                return _instance;
            }
        }

        public static DatabaseContext DatabaseContext = new DatabaseContext();

        /// <summary>
        /// Репозиторий для работы с записями задач.
        /// </summary>
        public ITaskRecordRepository TaskRecordRepository { get; private set; } = new TaskRecordRepository();

        /// <summary>
        /// Репозиторий для работы с типами задач.
        /// </summary>
        public ITaskTypeRepository TaskTypeRepository { get; private set; } = new TaskTypeRepository();

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        private DataService()
        {
        }
    }
}
