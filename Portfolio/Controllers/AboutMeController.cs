using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Briefcase.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            var profil = new Profil();
            return View(profil.Forces);
        }
    }
}
