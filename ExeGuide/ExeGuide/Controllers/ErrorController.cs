using Microsoft.AspNetCore.Mvc;

namespace ExeGuide.Controllers
{
    public class ErrorController : Controller
    {
        /// <summary>
        /// This controller class we use to implement the different errors and to throw the right error view tho the user
        /// </summary>
        /// <param name="statusCode"></param>
        /// <returns></returns>

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }
            if (statusCode == 401)
            {
                return View("Error401");
            }
            if (statusCode == 404)
            {
                return View("PageNotFound");
            }

            return View();


        }
    }
}
