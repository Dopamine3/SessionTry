using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace SessionTry.Controllers
{
    [Route("")]
    public class ValuesController : Controller
    {

        const string UserName = "";
        const string Id = "";

        [HttpGet("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("log")]
        public IActionResult Login(string username)
        {



            HttpContext.Session.SetString(UserName, username);
            return RedirectToAction("Post");
        }

        [HttpGet("postname")]
        public IActionResult Post()
        {
            var name = HttpContext.Session.GetString(UserName);
            return Content($"Name: \"{name}\",");
        }
    }
}
