using System.Web.Http;
using Owin;
using LanguageMentor.Web.Api.App_Start;

namespace LanguageMentor.Web.Api
{
    /// <summary>
    /// Startup class for OWIN configuration.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configures application components and includes them in the application pipeline.
        /// </summary>
        /// <param name="app">An application middleware builder.</param>
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            WebApiConfig.Configure(config);
            app.UseWebApi(config);
        }
    }
}