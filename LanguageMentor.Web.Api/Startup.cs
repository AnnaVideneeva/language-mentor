using System.Web.Http;
using Owin;
using Microsoft.Owin;
using LanguageMentor.Core.IoC;
using LanguageMentor.Core.IoC.Extensions;
using LanguageMentor.Web.Api;
using LanguageMentor.Web.Api.Configurations;
using LanguageMentor.Web.Api.Configurations.GlobalExceptionConfigurations;

[assembly: OwinStartup(typeof(Startup))]
namespace LanguageMentor.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            // app.Use<GlobalExceptionMiddleware>();

            var ioc = Ioc.CreateContainer();
            ioc.ApplyDependencies();

            config.WebApiConfigure();
            config.DependencyResolver = ioc.ToUnityResolver();

            app.UseWebApi(config);
        }
    }
}