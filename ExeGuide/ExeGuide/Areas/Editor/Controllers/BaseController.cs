using ExeGuide.DataBase.Data.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using static ExeGuide.Areas.Editor.Constants.EditorConstants;

namespace ExeGuide.Areas.Editor.Controllers
{
    [Area(AreaName)]
    [Route("Editor/[controller]/[Action]/{id?}")]
    [Authorize(Roles = EditorRolleName)]
    public class BaseController : Controller
    {

    }
}