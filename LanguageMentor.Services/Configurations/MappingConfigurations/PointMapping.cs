using AutoMapper;
using LanguageMentor.Data.Entities;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Logic.Configurations.MappingConfigurations
{
    public class PointMapping
    {
        public static void CreateMap(IProfileExpression mapperProfile)
        {
            ToServiceModel(mapperProfile);
            ToDbModel(mapperProfile);
        }

        private static void ToServiceModel(IProfileExpression mapper)
        {
            mapper.CreateMap<Point, PointEntity>();
        }

        private static void ToDbModel(IProfileExpression mapper)
        {
            mapper.CreateMap<PointEntity, Point>();
        }
    }
}