using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MvcApplication1
{
    public static class WebApiConfig
    {
        /// <summary>
        /// This is a comment
        /// BranchOffice
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
