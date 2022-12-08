using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using static ExeGuide.Areas.Writer.Constants.WriterConstants;

namespace ExeGuide.Areas.Writer.Controllers
{
    [Area(AreaName)]
    [Route("Writer/[controller]/[Action]/{id?}")]
    [Authorize(Roles = WriterRolleName)]
    public class BaseController : Controller
    {
    }
}
