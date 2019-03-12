using Unity;
using LanguageMentor.Data.EF6.Configurations;

namespace LanguageMentor.Services.Logic.Configurations
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterProviders(this IUnityContainer container)
        {
            return container;
        }
    }
}