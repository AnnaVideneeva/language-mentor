using AutoMapper;
using LanguageMentor.Services.Models;
using LanguageMentor.Web.Api.Models;

namespace LanguageMentor.Web.Api.Mapping
{
    public class AnswerModelMapping
    {
        public static void CreateMap(IProfileExpression mapperProfile)
        {
            ToServiceModel(mapperProfile);
            ToWebModel(mapperProfile);
        }

        private static void ToServiceModel(IProfileExpression mapper)
        {
            mapper.CreateMap<AnswerModel, Answer>();
        }

        private static void ToWebModel(IProfileExpression mapper)
        {
            mapper.CreateMap<Answer, AnswerModel>();
        }
    }
}