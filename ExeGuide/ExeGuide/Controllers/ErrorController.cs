﻿using Microsoft.AspNetCore.Mvc;

namespace ExeGuide.Controllers
{
    public class ErrorController : Controller
    {

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
