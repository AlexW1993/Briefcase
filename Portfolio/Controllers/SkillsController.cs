using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Briefcase.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            var programmingTechnologies = new ProgrammingTechnologies();
            return View(programmingTechnologies);
        }
    }
}
