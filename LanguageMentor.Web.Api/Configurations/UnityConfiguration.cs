﻿using Unity;
using Unity.Lifetime;
using AutoMapper;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Logic.Services;
using LanguageMentor.Web.Api.Mapping;

namespace LanguageMentor.Web.Api.Configurations
{
    public static class UnityConfiguration
    {
        public static IUnityContainer ApplyDependencies(this IUnityContainer container)
        {
            return container
                .RegisterServices()
                .RegisterMappers();
        }

        private static IUnityContainer RegisterServices(this IUnityContainer container)
        {
            container.RegisterType<ITestsService, TestsService>(new HierarchicalLifetimeManager());

            return container;
        }

        private static IUnityContainer RegisterMappers(this IUnityContainer container)
        {
            Mapper.Initialize(mapperConfig =>
            {
                mapperConfig.AddProfile<WebApiMapperProfile>();
            });

            container.RegisterInstance(Mapper.Instance);

            return container;
        }
    }
}