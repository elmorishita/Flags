using Microsoft.AspNetCore.Mvc;

namespace Flags.Controllers
{
    public class FlagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
