using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ExeGuide.Areas.Editor.Controllers
{
    public class EditorController : BaseController
    {
        /// <summary>
        /// Returns the Indes view specificly for the editor
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
