using System.Web.Http;
using System.Web.Http.Cors;
using Owin;
using Microsoft.Owin;
using LanguageMentor.Web.Api;
using LanguageMentor.Web.Api.Configurations;
using LanguageMentor.Web.Api.Configurations.SwaggerConfigurations;

[assembly: OwinStartup(typeof(Startup))]
namespace LanguageMentor.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            // app.Use<GlobalExceptionMiddleware>();

            var cors = new EnableCorsAttribute("http://localhost:4200", "*", "*");

            config
                .WebApiConfigure()
                .RegisterUnityIoC()
                .RegisterSwagger()
                .EnableCors(cors);

            app.UseWebApi(config);
        }
    }
}