using System;
using System.Collections.Generic;
using System.Linq;
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
            task.Status = Enums.TaskStatus.Open;
            task.CreateDate = DateTime.Now;
            task.IsCompleted = false;
            return _taskRepository.Add(task);
        }

        public void Delete(int taskId)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetAll()
        {
            return _taskRepository.GetAll().ToList();
        }

        public List<Task> GetAllOpen()
        {
            return _taskRepository.GetAll().Where(x => x.Status == Enums.TaskStatus.Open).ToList();
        }

        public Task GetById(int taskId)
        {
            throw new NotImplementedException();
        }

        public void Update(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
