using ExeGuide.Core.Models;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using ExeGuide.DataBase.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using static ExeGuide.Areas.Editor.Constants.EditorConstants;
using static ExeGuide.Areas.Writer.Constants.WriterConstants;

namespace ExeGuide.Controllers
{
    public class HomeController : Controller
    {
        
        public readonly IExerciseService data;

        public HomeController(IExerciseService _data)
        {
            this.data = _data;
        }
        /// <summary>
        /// This is the Index action. In it we have two checks so that the site redurects the different users to different pages. We have two roles so there are two ifs
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            if (User.IsInRole(EditorRolleName))
            {
                return RedirectToAction("Index", "Editor", new { area = "Editor" });
            }
            if (User.IsInRole(WriterRolleName))
            {
                return RedirectToAction("Index", "Writer", new { area = "Writer" });
            }
            return View();
        }


    }
}