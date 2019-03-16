using AutoMapper;
using LanguageMentor.Services.Models;
using LanguageMentor.Web.Api.Models;

namespace LanguageMentor.Web.Api.Configurations.MappingConfigurations
{
    public class ExaminationModelMapping
    {
        public static void CreateMap(IProfileExpression mapperProfile)
        {
            ToServiceModel(mapperProfile);
            ToWebModel(mapperProfile);
        }

        private static void ToServiceModel(IProfileExpression mapper)
        {
            mapper.CreateMap<ExaminationModel, Examination>();
        }

        private static void ToWebModel(IProfileExpression mapper)
        {
            mapper.CreateMap<Examination, ExaminationModel>();
        }
    }
}