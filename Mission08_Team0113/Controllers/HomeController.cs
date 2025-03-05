using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0113.Models;

namespace Mission08_Team0113.Controllers;

public class HomeController : Controller
{
    private ITaskRepository _repo;

    public HomeController(ITaskRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index()
    {
        var tasks = _repo.Tasks;
        return View(tasks);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var taskToDelete = _repo.Tasks.SingleOrDefault(t => t.TaskId == id);

        if (taskToDelete == null)
        {
            return NotFound();
        }
        
        return View(taskToDelete);
    }
    
    [HttpPost]
    public IActionResult ConfirmDelete(int TaskId)
    {
        var taskToDelete = _repo.Tasks.SingleOrDefault(t => t.TaskId == TaskId);

        if (taskToDelete == null)
        {
            return NotFound();
        }
        
        _repo.DeleteTask(taskToDelete);

        return RedirectToAction("Quadrant");
    }

    public IActionResult Task()
    {
        var newTask = new Mission08_Team0113.Models.Task();
        return View(newTask); 
    }

    
    [HttpGet]
    public IActionResult EditTask(int id)
    {
        var task = _repo.Tasks.SingleOrDefault(t => t.TaskId == id);

        if (task == null)
        {
            return NotFound();
        }

        return View("Task", task);
    }


    [HttpPost]
    public IActionResult CreateTask(Mission08_Team0113.Models.Task task)
    {
        if (ModelState.IsValid)
        {
            _repo.AddTask(task);
            return RedirectToAction("Index");
        }
    
        return View("Task", task);
    }


    [HttpGet]
    public IActionResult Quadrant()
    {
        var tasks = _repo.Tasks.ToList();

        return View(tasks);
    }
    
}
