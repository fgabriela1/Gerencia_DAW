using Administracion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Administracion.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Reporte()
        {
            return View("Reporte");
        }

        public IActionResult VentasReporte()
        {
            return View();
        }

        public IActionResult Buscar()
        {
            return View("Buscar");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
