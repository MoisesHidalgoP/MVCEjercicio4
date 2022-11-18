using Microsoft.AspNetCore.Mvc;
using MVCEjercicio4.Models;

namespace MVCEjercicio4.Controllers
{
    
    public class EmpleadoController : Controller
        

    {
        public MVCEjercicio4.Models.DeveloferContext db = new DeveloferContext();
        static List<Empleado> employed;
        public IActionResult Index()
        {
            var employed = db.Empleados.ToList();
            
            return View(employed);
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
