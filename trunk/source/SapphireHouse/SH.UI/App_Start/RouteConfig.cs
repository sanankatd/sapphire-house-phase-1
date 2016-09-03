using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace SH.UI
{
    public static class RouteConfig
    {
        /// <summary>
        /// Registers the custom routes.
        /// </summary>
        /// <param name="routes">The routes.</param>
        public static void RegisterCustomRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
               "Rings",
               "Rings",
               "~/Rings.aspx"
           );
        }
        public static void RegisterRoutes(RouteCollection routes)
        {            
            routes.EnableFriendlyUrls();          
        }       
    }
}
