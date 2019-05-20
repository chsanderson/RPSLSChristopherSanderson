using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RPSLSChristopherSanderson.Models;
//Christopher Sanderson

namespace RPSLSChristopherSanderson.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //this checks if sessions don't exist and if not creates new session variables called 'Won','Drawn' and 'Lost' all with a value of '0'
            if (HttpContext.Session.GetString("Won") == null)
            {
                HttpContext.Session.SetString("Won", 0.ToString());
            }

            if (HttpContext.Session.GetString("Drawn") == null)
            {
                HttpContext.Session.SetString("Drawn", 0.ToString());
            }

            if (HttpContext.Session.GetString("Lost") == null)
            {
                HttpContext.Session.SetString("Lost", 0.ToString());
            }
            return View();
        }

        //this clears the sessions being used, allowing users to be able to restart a fresh game with 'Win: 0 Drawn:0 Lost:0' being displayed on the home page (Index view in this controller)
        public IActionResult Clear()
        {
            HttpContext.Session.Clear();
            //this redirects the browser to the index view in the home controller
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
