using Briefcase.Models;
using Microsoft.AspNetCore.Mvc;

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
