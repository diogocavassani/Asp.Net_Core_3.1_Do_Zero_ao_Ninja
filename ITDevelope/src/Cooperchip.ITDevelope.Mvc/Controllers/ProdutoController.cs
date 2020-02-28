using Microsoft.AspNetCore.Mvc;

namespace Cooperchip.ITDevelope.Mvc.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lista()
        {
            return View();
        }
    }
}