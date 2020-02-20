using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        // GET: Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description")] ApplicationCore.Entity.Task task)
        {
            if (ModelState.IsValid)
            {
                _taskService.Add(task);
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }
    }
}
