using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //ovdje prima se paramtera s obzirom sto uspisemo u url-u
        {
            ViewData["Countries"] = new List<string>() // kako bi mogli u Viewu ovo iskoristiti
            {
                "India", "US", "UK", "Canada"
            };
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}