using Microsoft.AspNetCore.Mvc;

namespace ExeGuide.Areas.Editor.Controllers
{
    public class EditorController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
