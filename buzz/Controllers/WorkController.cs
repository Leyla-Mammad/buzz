using Microsoft.AspNetCore.Mvc;

namespace buzz.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
