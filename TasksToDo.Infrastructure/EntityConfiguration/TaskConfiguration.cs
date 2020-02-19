using TasksToDo.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TasksToDo.Infrastructure.EntityConfiguration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> taskEntity)
        {
            taskEntity.HasKey(task => task.Id);
        }
    }
}
