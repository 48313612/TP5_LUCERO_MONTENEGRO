using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5_LUCERO_MONTENEGRO.Models;

namespace TP5_LUCERO_MONTENEGRO.Controllers;

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
    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Juego()
    {
        return View();
    }

    public IActionResult Creditos()
    {
        return View();
    }

      public IActionResult Habitacion1()
    {
        return View();
    }

}
