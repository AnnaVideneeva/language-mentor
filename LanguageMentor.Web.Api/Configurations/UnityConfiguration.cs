using Unity;
using Unity.Lifetime;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Logic.Services;

namespace LanguageMentor.Web.Api.Configurations
{
    /// <summary>
    /// Represents for Unity configuration.
    /// </summary>
    public static class UnityConfiguration
    {
        /// <summary>
        /// Applies the unity container.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns>Unity container.</returns>
        public static IUnityContainer ApplyDependencies(this IUnityContainer container)
        {
            return container
                .RegisterServices();
        }

        private static IUnityContainer RegisterServices(this IUnityContainer container)
        {
            container.RegisterType<ITestsService, TestsService>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}