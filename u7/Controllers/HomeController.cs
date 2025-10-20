using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using u7.Models;

namespace u7.Controllers
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
            //C# directamente en Razor
            DateTime hora = DateTime.Now
            var horaI = hora.ToString("hh:mm");

            var mensajeHora = Model.Hour >= 19 ? "Buenas noches" : Model.Hour >= 12 && Model.Hour < 19 ? "Buenas tardes" : "Buenos días";
            ViewBag.Nombre = "Fernando";
            return View();
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
