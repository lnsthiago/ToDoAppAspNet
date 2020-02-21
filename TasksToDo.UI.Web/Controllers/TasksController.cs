using Microsoft.AspNetCore.Mvc;
using System;
using TasksToDo.ApplicationCore.Enums;
using TasksToDo.ApplicationCore.Interfaces.Services;

namespace TasksToDo.UI.Web.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // GET: Tasks
        public IActionResult Index()
        {
            return View(_taskService.GetAllOpen());
        }

        public IActionResult CompletedTasks()
        {
            return View(_taskService.GetAllCompletedTasks());
        }

        public IActionResult DeletedTasks()
        {
            return View(_taskService.GetAllDeletedTasks());
        }

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title,Description")] ApplicationCore.Entity.Task task)
        {
            if (ModelState.IsValid)
            {
                _taskService.Add(task);
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }

        public IActionResult UpdateTitleAndDescription(int taskId, string taskTitle, string taskDescription)
        {
            var task = _taskService.GetById(taskId);
            task.Title = taskTitle;
            task.Description = taskDescription;
            _taskService.Update(task);

            return RedirectToAction("Index");
        }

        public void CompleteTask(int taskId)
        {
            _taskService.CompleteTask(taskId);
        }

        public void RemoveTask(int taskId)
        {
            _taskService.Delete(taskId);
        }
    }
}
