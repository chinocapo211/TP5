using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult Tutorial()
    {
        return View("tutorial");
    }
    public IActionResult Comenzar()
    {
        int habitacion = escape.estado();
        return View("habitacion" + habitacion);
    }
    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala != escape.estado()){
            return View("habitacion"+escape.estado());
        }
        if(escape.resolverSala(sala,clave) == true){
            if(escape.estado() == 4){
                return View("victoria");
            }
            else{
                return View("habitacion"+escape.estado());
            }
        }
        else{
            ViewBag.Error = "La clave que introdujiste es incorrecta";
            return View("habitacion"+escape.estado);
        }
    }
}
