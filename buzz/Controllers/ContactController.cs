using Microsoft.AspNetCore.Mvc;

namespace buzz.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
