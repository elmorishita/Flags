using Microsoft.AspNetCore.Mvc;

namespace Flags.Models
{
    public class FlagContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
