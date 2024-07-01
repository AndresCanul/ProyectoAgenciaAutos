using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using PRACTICA2_JN_WEB.Entities;
using PRACTICA2_JN_WEB.Models;

namespace PRACTICA2_JN_WEB.Controllers
{
    public class VendedorController(IVendedorModel iVendedorModel) : Controller
    {
        [HttpGet]
        public IActionResult RegistrarVendedor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarVendedor(Vendedor entidad)
        {
            var resp = iVendedorModel.RegistrarVendedor(entidad);

            if (resp.Codigo == 1)
                return RedirectToAction("PantallaPrincipal", "Inicio");

            ViewBag.msj = resp.Mensaje;
            return View();
        }
    }
}
