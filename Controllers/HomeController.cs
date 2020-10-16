using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assessment5a.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Assessment5a.Models;

namespace Assessment5a.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Welcome(LoginModel model)
        {
            if (string.Compare(model.Password, "open sesame", false) != 0)
                return View("WrongPassword");
            //ViewBag.Name = model.Name.ToUpper();
            //ViewBag.Length = model.Name.Length;
            var userModel = new UserModel();
            userModel.Name = model.Name.ToUpper();
            userModel.NameLength = model.Name.Length;
                return View(userModel);
        }
    }
}
