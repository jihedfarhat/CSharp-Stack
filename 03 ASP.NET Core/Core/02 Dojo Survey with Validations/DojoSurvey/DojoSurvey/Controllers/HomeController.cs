using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static List<Student> Students = new List<Student>();


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [HttpPost("student/create")]
    public IActionResult Create (Student newStudent)
    {
        if (ModelState.IsValid)
        {
            Students.Add(newStudent);
            return RedirectToAction("AllStudents");
        }
        else {
            return View("Index");
        }
    }
    [HttpGet("AllStudents")]
    public IActionResult AllStudents()
    {
    return View("AllStudents", Students);
    }
}
