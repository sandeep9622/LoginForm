using LoginForm.Models;
using LoginForm.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Controllers
{
    [Route("Account")]
    public class AccountController : Controller
    {
        private readonly IDapperService _dapper;
        public AccountController(IDapperService dapper)
        {
            _dapper = dapper;
        }
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            
            if (username != null && password != null)
            {
                Users result = await Task.FromResult(_dapper.Get<Users>($"select * from Users where Name = '" + username + "' and password = '" + password + "'", null, CommandType.Text));
                if(result != null)
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
