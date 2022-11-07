using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoItems;
using ToDoMVCClient.Models;

namespace ToDoMVCClient.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private ToDoContext _db;

    public HomeController(ILogger<HomeController> logger, ToDoContext context)
    {
        _logger = logger;
        _db = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _db.Users.ToListAsync());
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
}