using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Intro.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        //public string Index() => "This is a default action <b>Test test, HTML stuff</b>";
        public ActionResult Index() => View();

        // GET: /HelloWorld/Welcome
        //public string Welcome() => "Welcome action method";

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

        // GET: /HelloWorld/Greet
        public string Greet(string name, int num = 1) => HttpUtility.HtmlAttributeEncode($"Hello {name}, num is {num}");
    }
}