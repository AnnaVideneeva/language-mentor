﻿using AutoMapper;
using LanguageMentor.Services.Models;
using LanguageMentor.Web.Api.Models;

namespace LanguageMentor.Web.Api.Configurations.MappingConfigurations
{
    public class ExerciseModelMapping
    {
        public static void CreateMap(IProfileExpression mapperProfile)
        {
            ToServiceModel(mapperProfile);
            ToWebModel(mapperProfile);
        }

        private static void ToServiceModel(IProfileExpression mapper)
        {
            mapper.CreateMap<ExerciseModel, Exercise>();
        }

        private static void ToWebModel(IProfileExpression mapper)
        {
            mapper.CreateMap<Exercise, ExerciseModel>();
        }
    }
}