using Microsoft.AspNetCore.Mvc;

namespace Briefcase.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
