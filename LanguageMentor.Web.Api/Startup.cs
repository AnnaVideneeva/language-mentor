using System.Web.Http;
using Owin;
using LanguageMentor.Core.IoC;
using LanguageMentor.Core.IoC.Extensions;
using LanguageMentor.Web.Api.Configurations;

namespace LanguageMentor.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            var ioc = Ioc.CreateContainer();
            ioc.ApplyDependencies();

            config.WebApiConfigure();
            config.DependencyResolver = ioc.ToUnityResolver();

            app.UseWebApi(config);
        }
    }
}