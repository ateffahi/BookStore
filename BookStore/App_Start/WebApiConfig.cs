using BookStore.Tracing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Tracing;

namespace BookStore
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.EnableSystemDiagnosticsTracing();

            config.Services.Replace(typeof(ITraceWriter),new MyTrace());

            //SystemDiagnosticsTraceWriter traceWriter = config.EnableSystemDiagnosticsTracing();
            //traceWriter.IsVerbose = true;
            //traceWriter.MinimumLevel = TraceLevel.Debug;

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
