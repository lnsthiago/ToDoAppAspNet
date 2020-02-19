using System.Collections.Generic;
using TasksToDo.ApplicationCore.Entity;

namespace TasksToDo.ApplicationCore.Interfaces.Services
{
    public interface ITaskService
    {
        Task GetById(int taskId);
        
        List<Task> GetAll();
        
        Task Add(Task task);

        void Update(Task task);

        void Delete(int taskId);
    }
}
