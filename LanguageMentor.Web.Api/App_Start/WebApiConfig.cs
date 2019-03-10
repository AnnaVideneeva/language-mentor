using System.Net.Http.Headers;
using System.Web.Http;
using LanguageMentor.Core.IoC;
using LanguageMentor.Core.IoC.Extensions;
using LanguageMentor.Web.Api.Configurations;

namespace LanguageMentor.Web.Api.App_Start
{
    public class WebApiConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            var ioc = Ioc.Container.ApplyDependencies();

            config.DependencyResolver = ioc.ToUnityResolver();
        }
    }
}