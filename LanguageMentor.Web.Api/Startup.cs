using System.Web.Http;
using Owin;
using LanguageMentor.Web.Api.App_Start;

namespace LanguageMentor.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            WebApiConfig.Configure(config);
            app.UseWebApi(config);
        }
    }
}