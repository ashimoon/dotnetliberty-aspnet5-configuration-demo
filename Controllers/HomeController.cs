using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Configuration;
using ConfigDemo.Models;
using Microsoft.Framework.OptionsModel;

namespace ConfigDemo.Controllers
{
    public class HomeController : Controller
    {
        private IOptions<FooConfig> _config;

        public HomeController(IOptions<FooConfig> fooConfig)
        {
            _config = fooConfig;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = _config.Options.Bar;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
