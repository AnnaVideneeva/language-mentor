using Unity;
using Unity.Lifetime;
using LanguageMentor.Data.EF6.Providers;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Services.Logic.Configurations
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterProviders(this IUnityContainer container)
        {
            container.RegisterType<IExaminationProvider, ExaminationProvider>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}