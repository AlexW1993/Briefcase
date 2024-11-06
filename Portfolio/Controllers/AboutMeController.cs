using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Microsoft.AspNetCore.Localization;
using System.Diagnostics;
using Briefcase.Models;

namespace Briefcase.Controllers
{
    public class AboutMeController : Controller
    {
        private readonly ILogger<AboutMeController> _logger;

        public AboutMeController(ILogger<AboutMeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var profil = new Profil();
            return View(profil);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CultureConnexion(string newCulture, string URL)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(newCulture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddHours(3) });

            return LocalRedirect(URL);
        }
    }
}
