using AutoMapper;
using LanguageMentor.Data.Entities;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Implementation.Configurations.MappingConfigurations
{
    public class AnswerMapping
    {
        public static void CreateMap(IProfileExpression mapperProfile)
        {
            ToServiceModel(mapperProfile);
            ToDbModel(mapperProfile);
        }

        private static void ToServiceModel(IProfileExpression mapper)
        {
            mapper.CreateMap<Answer, AnswerEntity>();
        }

        private static void ToDbModel(IProfileExpression mapper)
        {
            mapper.CreateMap<AnswerEntity, Answer>();
        }
    }
}