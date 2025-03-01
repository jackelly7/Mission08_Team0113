using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0113.Models;

namespace Mission08_Team0113.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }
    
    public IActionResult Task()
    {
        return View();
    }
    
    public IActionResult View()
    {
        return View();
    }

    public IActionResult Quadrant()
    {
        return View();
    }
    // POST: Edit Task
    [HttpPost]
    public IActionResult Edit(Task updatedTask)
    {
        if (ModelState.IsValid)
        {
            Application.UpdateTask(updatedTask);
            return RedirectToAction("View");
        }
        return View(updatedTask);
    }

    // GET: Delete Confirmation Page
    public IActionResult Delete(int id)
    {
        var task = Application.GetTaskById(id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    // POST: Delete Task
    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        Application.DeleteTask(id);
        return RedirectToAction("View");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}