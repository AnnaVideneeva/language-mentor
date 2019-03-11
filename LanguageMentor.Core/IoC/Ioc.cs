using Unity;

namespace LanguageMentor.Core.IoC
{
    public static class Ioc
    {
        public static IUnityContainer CreateContainer()
        {
            return new UnityContainer();
        }
    }
}
