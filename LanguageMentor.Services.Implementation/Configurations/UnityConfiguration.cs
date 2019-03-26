using Unity;
using Unity.Lifetime;
using LanguageMentor.Data.EF6.Providers;
using LanguageMentor.Data.Providers;
using LanguageMentor.Services.Implementation.Converters;
using LanguageMentor.Services.Interfaces.Converters;
using LanguageMentor.Services.Interfaces.Handlers;
using LanguageMentor.Services.Implementation.Handlers;

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

        public static IUnityContainer RegisterSerializers(this IUnityContainer container)
        {
            container.RegisterType<IExaminationFileSerializer, ExaminationFileSerializer>(new PerResolveLifetimeManager());

            return container;
        }

        public static IUnityContainer RegisterHandlers(this IUnityContainer container)
        {
            container.RegisterType<ILevelCalculationHandler, LevelCalculationHandler>(new PerResolveLifetimeManager());

            return container;
        }
    }
}