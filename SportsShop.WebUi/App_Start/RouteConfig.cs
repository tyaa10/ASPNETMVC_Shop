using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAppMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
            );

            /*routes.MapRoute(
                name: "DefaultProcessPost",
                url: "Default/ProcessPost/{id}",
                defaults: new { controller = "Default", action = "ProcessPost", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ItStep",
                url: "ItStep/{action}/{id}",
                defaults: new { controller = "ItStep", action = "Index", id = UrlParameter.Optional }
            );*/
        }
    }
}
