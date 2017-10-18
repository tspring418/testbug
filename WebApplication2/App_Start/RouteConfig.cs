using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        private static object entry;

        public static void RegisterRoutes(RouteCollection routes)
        {
            int ilast4 = 3;
            string last4 = "a";
            if (!int.TryParse(last4, out int _))

                //throw new Exception("APC5: Invalid last4 Passed");
                //if (int.TryParse(last4, out ilast4) == false) throw new Exception("APC5: Invalid last4 Passed");

                if (ilast4 is int i)
                {

                }
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
           
        }
    }
}
