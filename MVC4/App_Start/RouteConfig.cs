using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //ovom linijom se odreduje da aplikacija kada se otvori
                //da se prvo pokrene Home controller i index funkcija
                //home i index su ovdje postavljeni defaultni
                //ako ne upisemo nista u urlu, oni ce biti automatski pozvani
                //ako ne postoji kontroler/funkciju s tim imenom, aplikacija ce bacat gresku
            );
        }
    }
}
