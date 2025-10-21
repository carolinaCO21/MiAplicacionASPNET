using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using u7.Interfaces;
using u7.Models;
using u7.Models.Entities;
using u7.Models.ViewModels;

namespace u7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepoPersona _repoPersona;

        public HomeController(ILogger<HomeController> logger, IRepoPersona repoPersona)
        {
            _logger = logger;
            _repoPersona = repoPersona;
        }

        public IActionResult Index()
        {
             DateTime fechaActual = DateTime.Now;

            // 1. Obtener los datos de la entidad Persona
            Persona miPersona = _repoPersona.GetPersonaSimulada();

            // 2. Asignar el Saludo a ViewData
            ViewData["Saludo"] = ObtenerSaludoSegunHora(fechaActual);

            // 3. Asignar la Fecha Larga a ViewBag
            // (ViewBag es dinámico y usa la clave como propiedad, ej: ViewBag.FechaActual)
            ViewBag.FechaActual = fechaActual.ToString("D", new CultureInfo("es-ES"));

            // 4. Crear una instancia del ViewModel SOLO con la entidad Persona
            PersonaViewModel miViewModel = new PersonaViewModel
            {
                // Ya no asignamos Saludo ni FechaActual aquí.
                DatosPersona = miPersona
            };

            // 5. Pasar el ViewModel (que ahora solo contiene la Persona) a la vista
            return View(miViewModel);


            /*
            DateTime fechaActual = DateTime.Now;

            
            Persona miPersona = _repoPersona.GetPersonaSimulada();

            // Rellenar y pasar el ViewModel (como se explicó anteriormente)
            PersonaViewModel miViewModel = new PersonaViewModel
            {
                Saludo = ObtenerSaludoSegunHora(fechaActual),
                FechaActual = fechaActual.ToString("D", new CultureInfo("es-ES")),
                DatosPersona = miPersona
            };

            return View(miViewModel);


            */
        }

        /// <summary>
        /// Determina si es Buenos días, Buenas tardes o Buenas noches
        /// </summary>
        private string ObtenerSaludoSegunHora(DateTime fecha)
        {
            return fecha.Hour >= 19 ? "Buenas noches" : fecha.Hour >= 12 && fecha.Hour < 19 ? "Buenas tardes" : "Buenos días";
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
