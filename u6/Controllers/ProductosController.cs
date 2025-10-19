
using Microsoft.AspNetCore.Mvc;

namespace u6.Controllers
{
    // EJERCICIO 2: Crear nuevo controlador
    public class ProductosController : Controller
    {
        public IActionResult ListadoProductos()
        {
            // La vista contendrá el listado inventado.
            return View();
        }
    }
}
