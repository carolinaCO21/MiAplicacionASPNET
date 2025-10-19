using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using u6.Models;
using u6.Services;

namespace u6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TablaMultiplicacionService _tablaService;

        public HomeController(ILogger<HomeController> logger, TablaMultiplicacionService tablaService)
        {
            _logger = logger;
            _tablaService = tablaService;
        }

        // -----------------------------------------------------------------
        // EJERCICIO 1 & Enlace para Ejercicio 2
        // -----------------------------------------------------------------
        public IActionResult Index()
        {
            // La vista simplemente escribirá "Hola Mundo"
            return View();
        }
        // -----------------------------------------------------------------
        // EJERCICIO 3: Razor y la hora actual
        // -----------------------------------------------------------------
        public IActionResult Hora()
        {
            // Pasamos la hora actual al modelo de la vista
            return View(DateTime.Now);
        }
        // -----------------------------------------------------------------
        // EJERCICIO 4: Tabla de Multiplicaciones (Usa el Service)
        // -----------------------------------------------------------------
        public IActionResult Multiplicacion()
        {
            // Llama al servicio de la capa de Aplicación
            var tabla = _tablaService.GenerarTabla();

            // Pasa el modelo a la vista
            return View(tabla);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
