using Microsoft.AspNetCore.Mvc;

namespace ExeGuide.Areas.Writer.Controllers
{
    public class WriterController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
