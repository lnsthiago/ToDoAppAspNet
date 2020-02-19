using System.Collections.Generic;
using TasksToDo.ApplicationCore.Entity;
using TasksToDo.ApplicationCore.Interfaces.Repositories;
using TasksToDo.ApplicationCore.Interfaces.Services;

namespace TasksToDo.ApplicationCore.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Task Add(Task task)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int taskId)
        {
            throw new System.NotImplementedException();
        }

        public List<Task> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task GetById(int taskId)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Task task)
        {
            throw new System.NotImplementedException();
        }
    }
}
