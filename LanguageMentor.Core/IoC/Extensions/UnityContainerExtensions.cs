using System.Web.Http.Dependencies;
using Unity;

namespace LanguageMentor.Core.IoC.Extensions
{
    /// <summary>
    /// Represent extensions for UnityContainer
    /// </summary>
    public static class UnityContainerExtensions
    {
        /// <summary>
        /// Gets UnityResolver using existing UnityContainer
        /// </summary>
        /// <param name="container"></param>
        /// <returns>A created <see cref="LanguageMentor.Core.IoC.UnityResolver"/> object.</returns>
        public static IDependencyResolver ToUnityResolver(this IUnityContainer container)
        {
            return new UnityResolver(container);
        }
    }
}
