using Unity;

namespace LanguageMentor.Core.IoC
{
    /// <summary>
    /// IoC container factory method.
    /// </summary>
    public static class Ioc
    {
        private static IUnityContainer _container;

        /// <summary>
        /// Gets Singleton IUnity container
        /// </summary>
        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = CreateContainer();
                }

                return _container;
            }
        }

        /// <summary> Creates a new <see cref="T:Microsoft.Practices.Unity.IUnityContainer"/> instance.
        /// </summary>
        /// <returns>A newly created <see cref="T:Microsoft.Practices.Unity.IUnityContainer"/> object.</returns>
        private static IUnityContainer CreateContainer()
        {
            return new UnityContainer();
        }
    }
}
