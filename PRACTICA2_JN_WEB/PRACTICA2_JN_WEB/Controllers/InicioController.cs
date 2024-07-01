using Microsoft.AspNetCore.Mvc;

namespace PRACTICA2_JN_WEB.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult PantallaPrincipal()
        {
            return View();
        }
    }
}
