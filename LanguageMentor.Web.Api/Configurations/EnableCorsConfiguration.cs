using System.Web.Http;
using System.Web.Http.Cors;

namespace LanguageMentor.Web.Api.Configurations
{
    public static class EnableCorsConfiguration
    {
        public static HttpConfiguration EnableCorsConfigure(this HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");

            config.EnableCors(cors);

            return config;
        }
    }
}