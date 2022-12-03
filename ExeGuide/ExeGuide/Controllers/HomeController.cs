using ExeGuide.Core.Models;
using ExeGuide.Core.Services.Exercises;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using static ExeGuide.Areas.Editor.Constants.EditorConstants;

namespace ExeGuide.Controllers
{
    public class HomeController : Controller
    {
        public readonly IExerciseService data;

        public HomeController(IExerciseService _data)
        {
            this.data = _data;
        }
        public IActionResult Index()
        {
            if (User.IsInRole(EditorRolleName))
            {
                return RedirectToAction("Index", "Editor", new { area = "Editor" });
            }

            var exercises = data.AllShowingSlide();
            return View(exercises);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}