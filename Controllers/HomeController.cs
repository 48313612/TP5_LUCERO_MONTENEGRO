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
        bool salaCorrecta = false;
        int estadoDeJuego = Escape.GetEstadoJuego();
        if(Sala == estadoDeJuego)
        {
            salaCorrecta = true;
        }
        else
        {
            return RedirectToAction($"Habitacion{estadoDeJuego}");
        }

        bool resolvio = Escape.ResolverSala(Sala, Incognita, salaCorrecta);
        if(!resolvio)
        {
            ViewBag.Error = "Respuesta incorrecta. Vuelva a intentar otra vez";
            return RedirectToAction($"Habitacion{estadoDeJuego}");
        }
        else
        {       
             ViewBag.Error = "";
            return View($"Habitacion{estadoDeJuego}");
        }

    }

}
