using AutoMapper;
using LanguageMentor.Services.Models;
using LanguageMentor.Web.Api.Models;

namespace LanguageMentor.Web.Api.Configurations.MappingConfigurations
{
    public class PointModelMapping
    {
        public static void CreateMap(IProfileExpression mapperProfile)
        {
            ToServiceModel(mapperProfile);
            ToWebModel(mapperProfile);
        }

        private static void ToServiceModel(IProfileExpression mapper)
        {
            mapper.CreateMap<PointModel, Point>();
        }

        private static void ToWebModel(IProfileExpression mapper)
        {
            mapper.CreateMap<Point, PointModel>();
        }
    }
}