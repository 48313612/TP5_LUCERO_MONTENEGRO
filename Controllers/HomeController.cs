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

     public IActionResult Comenzar()
    {
        int estadoDeJuego = Escape.GetEstadoJuego();
        return View($"Habitacion{estadoDeJuego}");
    }

    public IActionResult Habitacion(int Sala, string Incognita)
    {
        //resolver sala?
        return View();
    }

}
