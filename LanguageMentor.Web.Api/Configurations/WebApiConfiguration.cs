﻿using System.Net.Http.Headers;
using System.Web.Http;

namespace LanguageMentor.Web.Api.Configurations
{
    public static class WebApiConfiguration
    {
        public static HttpConfiguration WebApiConfigure(this HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            // config.Services.Replace(typeof(IExceptionHandler), new LanguageMentorExceptionHandler());

            return config;  
        }
    }
}