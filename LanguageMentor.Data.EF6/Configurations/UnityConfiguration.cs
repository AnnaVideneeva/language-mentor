using Unity;
using Unity.Injection;
using Unity.Lifetime;
using LanguageMentor.Core.Data;
using LanguageMentor.Core.Data.EF6;
using LanguageMentor.Data.EF6.Configurations.DbContexts;

namespace LanguageMentor.Data.EF6.Configurations
{
    public static class UnityConfiguration
    {
        public static void RegisterDefaultUnitOfWork(this IUnityContainer container, string connectionString)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork<LanguageMentorDbContext>>(new PerResolveLifetimeManager());
            container.RegisterType<LanguageMentorDbContext>(new PerResolveLifetimeManager(), new InjectionConstructor(connectionString));
        }
    }
}