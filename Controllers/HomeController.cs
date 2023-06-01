using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Tutorial()
    {
        return View("tutorial");
    }
    public IActionResult Comenzar()
    {
        int habitacion = escape.estado();
        return View("habitacion" + (habitacion));
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        ViewBag.Error = null;
        if(sala == escape.estado()){
            if(escape.resolverSala(sala,clave) == false) ViewBag.Error = "La clave que introdujiste es incorrecta";
            if(escape.estado() == 5) return View("Victoria");
            return View("habitacion"+escape.estado());
        }
        return View("Habitacion"+escape.estado());
    }
}
