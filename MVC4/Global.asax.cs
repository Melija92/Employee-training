using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC4
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() //ovaj event se executa kada se aplikacije pokrene!
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters); //nalazi se u App_Start folderu
            RouteConfig.RegisterRoutes(RouteTable.Routes); //nalazi se u App_Start folderu
            BundleConfig.RegisterBundles(BundleTable.Bundles); //nalazi se u App_Start folderu
        }
    }
}
