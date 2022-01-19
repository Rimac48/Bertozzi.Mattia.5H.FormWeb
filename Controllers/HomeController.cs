using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bertozzi.Mattia._5H.FormWeb.Models;

namespace Bertozzi.Mattia._5H.FormWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private static List<Prenotazione> _prenotazioni {get;set;} = new() ;

    public HomeController(ILogger<HomeController> logger)
    {
        // _prenotazioni = new List<Prenotazione>();
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

    [HttpGet]
    public IActionResult Prenota()
    {
        //vengo qui solo con la richiesta HTTP GET
        return View();//vai a prendere la view che si chiama prenota
    }

    [HttpPost]
    public IActionResult Prenota(Prenotazione p)
    {
        //vengo qui con il click del button della form
        _prenotazioni.Add(p);
        return View("Prenotato",_prenotazioni);//vai a prendere la view che si chiama prenota
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
