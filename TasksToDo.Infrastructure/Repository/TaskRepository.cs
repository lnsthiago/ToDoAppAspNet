using TasksToDo.ApplicationCore.Entity;
using TasksToDo.ApplicationCore.Interfaces.Repositories;
using TasksToDo.Infrastructure.Data;

namespace TasksToDo.Infrastructure.Repository
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        public TaskRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
