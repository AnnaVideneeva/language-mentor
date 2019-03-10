using Unity;

namespace LanguageMentor.Core.IoC
{
    public static class Ioc
    {
        private static IUnityContainer _container;

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

        private static IUnityContainer CreateContainer()
        {
            return new UnityContainer();
        }
    }
}
