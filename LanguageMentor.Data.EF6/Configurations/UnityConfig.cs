using Unity;
using Unity.Injection;
using Unity.Lifetime;
using LanguageMentor.Core.Data;
using LanguageMentor.Core.Data.EF6;
using LanguageMentor.Data.EF6.Configurations.DbContexts;

namespace LanguageMentor.Data.EF6.Configurations
{
    public static class UnityConfig
    {
        public static void RegisterDefaultUnitOfWork(this IUnityContainer container, string connectionString)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork<LanguageMentorDbContext>>(new HierarchicalLifetimeManager());
            container.RegisterType<LanguageMentorDbContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(connectionString));
        }
    }
}