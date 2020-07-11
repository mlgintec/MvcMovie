using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
    //    public IActionResult Index()
        {
            return "Mon action par défaut ...";
         //   return View();
        }
        /* public string Welcome()
         {
             return "Welcome Action ...";
             //   return View();
         } /**/
        /* avec Paramètres /**/
        /*
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        } /**/
        /* avec Paramètres et vue /**/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
