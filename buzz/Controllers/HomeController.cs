using buzz.Models;
using buzz.Viewmodels.home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace buzz.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {

            List<recentwork> recentworks = new List<recentwork>()
            {

                new recentwork() {Id=1, File="recent-work-01.jpg", name="Social Media", description="Ullamco laboris nisi ut aliquip ex"},
                new recentwork() {Id=2, File="recent-work-02.jpg", name="Web Marketing", description="Ullamco laboris nisi ut aliquip ex"},
                new recentwork() {Id=3, File="recent-work-03.jpg", name="R & D", description="Ullamco laboris nisi ut aliquip ex"},
                new recentwork() {Id=4, File="recent-work-04.jpg", name="Public Relation", description="Ullamco laboris nisi ut aliquip ex"},
                new recentwork() {Id=5, File="recent-work-05.jpg", name="Branding", description="Ullamco laboris nisi ut aliquip ex"},
                new recentwork() {Id=6, File="recent-work-06.jpg", name="Creative Design", description="Ullamco laboris nisi ut aliquip ex"},





            };

            Homeindexviewmodel model = new Homeindexviewmodel
            { recentworks = recentworks };
            
            return View(model);
        }
    }
}