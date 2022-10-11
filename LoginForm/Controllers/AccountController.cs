using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Controllers
{
    [Route("Account")]
    public class AccountController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username != null && password != null && username.Equals("sandeep") && password.Equals("deep"))
            {
                byte[] usernameBytes = Encoding.ASCII.GetBytes(username);
                HttpContext.Session.Set("username", usernameBytes);
                return View("Success");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Index");
            }
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}
