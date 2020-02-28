using Cooperchip.ITDevelope.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cooperchip.ITDevelope.Mvc.Controllers
{
    [Route("")]
    [Route("gestao-de-pacientes")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index()
        {
            return View();
        }

        
        [Route("sobre-nos")]
        [Route("sobre")]
        [Route("quem-somos")]
        public IActionResult Sobre()
        {
            return View();
        }

        [Route("Privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Icones")]
        public IActionResult Icones()
        {
            return View();
        }
        [Route("Erro")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
