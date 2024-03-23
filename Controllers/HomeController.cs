using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TECHSTORE.Models;

namespace TECHSTORE.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }



    [HttpPost]
    public IActionResult Create([Bind("Nombre,Descripcion,Precio")] Producto producto)
    {
        if (ModelState.IsValid)
        {
            ViewData["Message"] = "Ya se calculo el IGV";
            Double precio = producto.Precio;
            Double IGV = 0.18;
            double impuesto = precio * IGV;
            ViewData["ImpuestoCalculado"] = "El impuesto a pagar es" + impuesto;            
            return View("Index");
        }
        else{
            ViewData["Message"] = "ERROR";
        }
        return View("Index");
    }


}


