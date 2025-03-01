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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}