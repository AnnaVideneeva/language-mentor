using System.Web.Http;
using System.Configuration;
using Unity;
using Unity.Lifetime;
using AutoMapper;
using LanguageMentor.Data.EF6.Configurations;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Implementation.Services;
using LanguageMentor.Services.Implementation.Configurations;
using LanguageMentor.Web.Api.Mapping;
using LanguageMentor.Services.Implementation.Configurations.MappingConfigurations;
using LanguageMentor.Core.IoC;
using LanguageMentor.Core.IoC.Extensions;

namespace LanguageMentor.Web.Api.Configurations
{
    public static class UnityConfiguration
    {
        public static HttpConfiguration RegisterUnityIoC(this HttpConfiguration config)
        {
            var ioc = Ioc.CreateContainer();
            ioc.ApplyDependencies();

            config.DependencyResolver = ioc.ToUnityResolver();

            return config;
        }

        private static IUnityContainer ApplyDependencies(this IUnityContainer container)
        {
            return container
                .RegisterServices()
                .RegisterMappers()
                .RegisterSerializers()
                .RegisterHandlers()
                .RegisterProviders()
                .RegisterUnitOfWork();
        }

        private static IUnityContainer RegisterServices(this IUnityContainer container)
        {
            container.RegisterType<IExaminationService, ExaminationService>(new PerResolveLifetimeManager());

            return container;
        }

        private static IUnityContainer RegisterMappers(this IUnityContainer container)
        {
            Mapper.Initialize(mapperConfig =>
            {
                mapperConfig.AddProfile<WebApiMapperProfile>();
                mapperConfig.AddProfile<ServicesMapperProfile>();
            });

            container.RegisterInstance(Mapper.Instance);

            return container;
        }

        private static IUnityContainer RegisterUnitOfWork(this IUnityContainer container)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LanguageMentorConnection"]?.ConnectionString;
            container.RegisterDefaultUnitOfWork(connectionString);
            return container;
        }
    }
}