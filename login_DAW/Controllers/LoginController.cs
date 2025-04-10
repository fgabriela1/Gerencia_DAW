using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class LoginController : Controller
{
    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string email, string contrasena)
    {
        var empleado = _context.Empleados
            .FirstOrDefault(e => e.Email == email && e.Contrasena == contrasena);

        if (empleado != null)
        {
            TempData["EmpleadoNombre"] = $"{empleado.Nombre} {empleado.Apellido}";
            return RedirectToAction("Panel", "Login");
        }

        ViewBag.Error = "Correo o contraseña incorrectos";
        return View();
    }

    public IActionResult Panel()
    {
        ViewBag.NombreEmpleado = TempData["EmpleadoNombre"];
        return View();
    }
}

