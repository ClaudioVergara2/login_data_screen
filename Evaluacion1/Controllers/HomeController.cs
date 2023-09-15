using Evaluacion1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Evaluacion1.Controllers
{
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
        public IActionResult DataScreen(Datos datos, string usuario)
        {
            if (datos.nombres != "")
            {
                ViewData["respuesta"] = datos;
            }
            ViewData["usuario"] = usuario;
            return View();
        }

        [HttpPost]
        public IActionResult ValidarLogin([FromBody] Login Login)
        {
            if ((Login.usuario == "ADMIN" && Login.contraseña == "ADMIN") ||
                (Login.usuario == "Pedro" && Login.contraseña == "123456"))
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}