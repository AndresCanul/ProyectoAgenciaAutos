using Microsoft.AspNetCore.Mvc;
using PRACTICA2_JN_WEB.Entities;
using PRACTICA2_JN_WEB.Models;
using System.Text.Json;

namespace PRACTICA2_JN_WEB.Controllers
{
    public class VehiculoController(IVehiculoModel iVehiculoModel) : Controller
    {
        [HttpGet]
        public IActionResult ConsultarVehiculos()
        {
            var respuesta = iVehiculoModel.ConsultarVehiculos();

            if (respuesta.Codigo == 1)
            {
                var datos = JsonSerializer.Deserialize<List<Vehiculo>>((JsonElement)respuesta.Contenido!);
                return View(datos);
            }

            return View(new List<Vehiculo>());
        }

        [HttpGet]
        public IActionResult RegistrarVehiculo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarVehiculo(Vehiculo entidad)
        {
            var resp = iVehiculoModel.RegistrarVehiculo(entidad);

            if (resp.Codigo == 1)
                return RedirectToAction("ConsultarVehiculos", "Vehiculo");

            ViewBag.msj = resp.Mensaje;
            return View();
        }
    }
}
