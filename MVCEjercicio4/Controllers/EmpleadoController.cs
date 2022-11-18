using Microsoft.AspNetCore.Mvc;
using MVCEjercicio4.Models;

namespace MVCEjercicio4.Controllers
{
    
    public class EmpleadoController : Controller

    {
       
        public MVCEjercicio4.Models.DeveloferContext db = new DeveloferContext();
        public IActionResult Index()
        {
            var empleados = db.Empleados.ToList();
            TempData["ListaEmpleados"] = empleados;
            return View(empleados);
        }

        [HttpPost]
        public IActionResult Index(int IdArea)
        {
            Empleado empleados = db.Empleados.Where(e => e.IdArea == IdArea).FirstOrDefault();
            if (empleados != null)
            {
                ViewBag.Area = "Empleado" + empleados.Nombre + " - " + "Area: " + empleados.IdAreaNavigation.Area1;
            }
            return View(empleados);
        }
    }
}
