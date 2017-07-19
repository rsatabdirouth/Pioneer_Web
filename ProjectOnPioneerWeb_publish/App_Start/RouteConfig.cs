using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectOnPioneerWeb_publish
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute("Home", "home", new { controller = "Home", action = "Index" });
            routes.MapRoute("Careers", "careers", new { controller = "Home", action = "Careers" });
            routes.MapRoute("ContactUs", "contact-us", new { controller = "Home", action = "ContactUs" });
            routes.MapRoute("AboutUs", "about-us", new { controller = "Home", action = "AboutUs" });
            routes.MapRoute("PrivacyPolicy", "privacy-policy", new { controller = "Home", action = "AboutUs" });
            routes.MapRoute("CookiePolicy", "cookie-policy", new { controller = "Home", action = "AboutUs" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}