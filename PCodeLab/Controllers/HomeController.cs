using System;
using System.Web.Mvc;

namespace PCodeLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CurrentYear = DateTime.Now.Year;
            return View();
        }

        private static string BuildMailBody(string name, string email, string message)
        {
            var res = "<p>You have a new contact from PCodelab: </p>";
            res += "<strong>Name: </strong>" + name + "<br/>";
            res += "<strong>Email: </strong>" + email + "<br/>";
            res += "<strong>Message: </strong>" +  message + "<br/>";
            return res;
        }
    }
}