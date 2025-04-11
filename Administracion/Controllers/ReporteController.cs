using Microsoft.AspNetCore.Mvc;

namespace Administracion.Controllers
{
    public class ReporteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
