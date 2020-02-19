using Microsoft.EntityFrameworkCore;
using TasksToDo.ApplicationCore.Entity;
using TasksToDo.Infrastructure.EntityConfiguration;

namespace TasksToDo.Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
        }
    }
}
