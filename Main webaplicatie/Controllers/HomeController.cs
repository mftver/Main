using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Main_webaplicatie.Models;

namespace Main_webaplicatie.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Index(string username, string password)
        {

            //data opvangen vanuit post

            //models gebruiken voor data uit database halen

            //Person person = LoginModel.login(username.password);

            //data doorstuuren naar een pagina

            //ViewBag.logedinuser = person;
            return View(ViewBag);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
