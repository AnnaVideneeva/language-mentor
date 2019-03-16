using Unity;
using Unity.Lifetime;
using LanguageMentor.Data.EF6.Providers;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Services.Implementation.Configurations
{
    public static class UnityConfiguration
    {
        public static IUnityContainer RegisterProviders(this IUnityContainer container)
        {
            container.RegisterType<IExaminationProvider, ExaminationProvider>(new PerResolveLifetimeManager());
            container.RegisterType<IExerciseProvider, ExerciseProvider>(new PerResolveLifetimeManager());
            container.RegisterType<IPointProvider, PointProvider>(new PerResolveLifetimeManager());
            container.RegisterType<IAnswerProvider, AnswerProvider>(new PerResolveLifetimeManager());
            container.RegisterType<ILevelProvider, LevelProvider>(new PerResolveLifetimeManager());

            return container;
        }
    }
}