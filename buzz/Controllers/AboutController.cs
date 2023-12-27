using Microsoft.AspNetCore.Mvc;

namespace buzz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutIndex()
        {
            return View();
        }
    }
}
