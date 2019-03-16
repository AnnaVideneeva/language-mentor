using AutoMapper;
using LanguageMentor.Data.Entities;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Implementation.Configurations.MappingConfigurations
{
    public class ExerciseMapping
    {
        public static void CreateMap(IProfileExpression mapperProfile)
        {
            ToServiceModel(mapperProfile);
            ToDbModel(mapperProfile);
        }

        private static void ToServiceModel(IProfileExpression mapper)
        {
            mapper.CreateMap<Exercise, ExerciseEntity>();
        }

        private static void ToDbModel(IProfileExpression mapper)
        {
            mapper.CreateMap<ExerciseEntity, Exercise>();
        }
    }
}
