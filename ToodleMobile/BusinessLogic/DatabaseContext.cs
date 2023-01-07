using BusinessLogic.DTO;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TaskType> TaskTypes => Set<TaskType>();
        public DatabaseContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Egor\Desktop\Toodle\toodleDatabase.db");
        }
    }
}
