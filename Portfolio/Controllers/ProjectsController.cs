using Microsoft.AspNetCore.Mvc;

namespace Briefcase.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
