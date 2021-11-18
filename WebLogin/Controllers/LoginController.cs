using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLogin.Models;

namespace WebLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetLoginData(LoginModel loginModel)
        {
            string username = loginModel.Username;
            string password = loginModel.Password;
            return View("~/Views/Login/Sucess.cshtml", loginModel);
        }
    }
}
