using Unity;
using Unity.Lifetime;
using LanguageMentor.Data.EF6.Providers;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Services.Implementation.Configurations
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterProviders(this IUnityContainer container)
        {
            container.RegisterType<IExaminationProvider, ExaminationProvider>(new HierarchicalLifetimeManager());
            container.RegisterType<IExerciseProvider, ExerciseProvider>(new HierarchicalLifetimeManager());
            container.RegisterType<IPointProvider, PointProvider>(new HierarchicalLifetimeManager());
            container.RegisterType<IAnswerProvider, AnswerProvider>(new HierarchicalLifetimeManager());
            container.RegisterType<ILevelProvider, LevelProvider>(new HierarchicalLifetimeManager());

            return container;
        }
    }
}