using buzz.Models;
using buzz.NewFolder1;
using buzz.Viewmodels.home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace buzz.Controllers
{
    public class HomeController : Controller
    {
    private readonly AppDbContext _appDb;
        public HomeController(AppDbContext appDbContext)
        {
            _appDb = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            List<recentwork> recentworks = await _appDb.recentworks.ToListAsync();

            Homeindexviewmodel model = new Homeindexviewmodel
            { 
            Recentworks = recentworks,
            };
            
            return View(model);
        }
    }
}