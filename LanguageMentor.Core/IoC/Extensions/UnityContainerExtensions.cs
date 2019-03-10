using System.Web.Http.Dependencies;
using Unity;

namespace LanguageMentor.Core.IoC.Extensions
{
    public static class UnityContainerExtensions
    {
        public static IDependencyResolver ToUnityResolver(this IUnityContainer container)
        {
            return new UnityResolver(container);
        }
    }
}
