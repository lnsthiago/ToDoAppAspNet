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
            return _taskRepository.GetById(taskId);
        }

        public void Update(Task task)
        {
            if (task.Id > 0)
            {
                task.UpdateDate = DateTime.Now;
                _taskRepository.Update(task);
            }
            else
            {
                task.CreateDate = DateTime.Now;
                _taskRepository.Add(task);
            }
        }

        public void CompleteTask(int taskId)
        {
            var task = _taskRepository.GetById(taskId);
            task.IsCompleted = true;
            task.Status = Enums.TaskStatus.Done;
            task.DoneDate = DateTime.Now;
            _taskRepository.Update(task);
        }
    }
}
