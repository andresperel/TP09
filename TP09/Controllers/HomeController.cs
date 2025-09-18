using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP09.Models;

namespace TP09.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.jugadoresCompetieron = Juego.devolverListaUsuarios();
        return View("Index");
    }
    public IActionResult comenzar(string username, int dificultad)
    {
        Juego.inicializarJuego(username, dificultad);
        return View("Index");
    }
    public IActionResult finJuego(int intentos)
    {
        
        return View("Index");
    }
}
