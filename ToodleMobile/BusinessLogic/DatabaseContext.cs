using BusinessLogic.DTO;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace BusinessLogic
{
    /// <summary>
    /// Контекст базы данных.
    /// </summary>
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// Типы задач.
        /// </summary>
        public DbSet<TaskType> TaskTypes => Set<TaskType>();

        /// <summary>
        /// Запись задачи.
        /// </summary>
        public DbSet<TaskRecord> TaskRecords => Set<TaskRecord>();

        public DatabaseContext()
        {
#if DEBUG
            Database.EnsureDeleted();//Каждый раз удаляем бд в дебаге, чтоб почистить таблицу.
#endif
            Database.EnsureCreated();
        }

        /// <summary>
        /// Обработка события конфигурации базы данных.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Egor\Desktop\Toodle\toodleDatabase.db");
        }
    }
}
