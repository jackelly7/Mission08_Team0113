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


    [HttpPost]
    public IActionResult Delete(int id)
    {
        var task = _repo.Tasks.FirstOrDefault(t => t.TaskId == id);
        if (task == null)
        {
            return NotFound();
        }

        return ViewTask();
    }


    public IActionResult ViewTask()
    {
        var task = _repo.Tasks.ToList();
        return View(task);
    }

    public IActionResult Quadrant(int quadrantId)
    {
        var tasks = _repo.Tasks.Where(t => t.TaskId == quadrantId).ToList();

        return View(tasks);
    }
    
}
