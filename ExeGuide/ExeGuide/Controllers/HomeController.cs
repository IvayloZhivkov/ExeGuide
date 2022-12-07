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
            return View();
        }


    }
}