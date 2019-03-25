using System.Web.Http;
using Owin;
using Microsoft.Owin;
using LanguageMentor.Core.IoC;
using LanguageMentor.Core.IoC.Extensions;
using LanguageMentor.Web.Api;
using LanguageMentor.Web.Api.Configurations;

[assembly: OwinStartup(typeof(Startup))]
namespace LanguageMentor.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            // app.Use<GlobalExceptionMiddleware>();

            config
                .WebApiConfigure()
                .RegisterUnityIoC()
                .RegisterSwagger();

            app.UseWebApi(config);
        }
    }
}